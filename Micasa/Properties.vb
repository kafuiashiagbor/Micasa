Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Vbe.Interop

Public Class Properties
    Private dtProperties As New DataTable

    Private Sub Properties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        Dim query = "SELECT PropertyTypeID, Description FROM PropertyType"
        CmbPropertyType.DataSource = DBManager.GetDataTable(query)
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs)
        ' Reload all data into the DataGridView
        LoadData()
        ' Clear the search text
        TxtSearch.Clear()
    End Sub

    Private Sub BtnMainpage_Click(sender As Object, e As EventArgs) Handles BtnMainpage.Click
        Me.Hide()

        Dim logour As New Mainpage
        logour.Show()
    End Sub

    Private Sub LoadData()
        Try
            ' This line of code selects all records from the properties table 
            Dim SQLQuery As String = "Select p.PropertyID, p.Address, p.Status, pt.Description As PropetyType, p.RentAmount, p.imagePath " &
                                    "From properties as p, propertyType as pt " &
                                    "WHERE p.TypeID = pt.PropertyTypeID "

            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(SQLQuery, con)
                    Using adapter As New SqlDataAdapter(cmd)

                        dtProperties.Clear()
                        adapter.Fill(dtProperties) ' Fill DataTable with sales data

                        ' Bind DataTable to BindingSource
                        bsProperties.DataSource = dtProperties

                        ' Bind BindingSource to DataGridView
                        DgvProperties.DataSource = bsProperties
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sales data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Event handler to load to load data into text boxes
    Private Sub BsProperties_PositionChanged(sender As Object, e As EventArgs) Handles bsProperties.PositionChanged
        Try
            If bsProperties.Position > -1 Then
                'display the recored for that row
                With dtProperties.Rows(bsProperties.Position)
                    TxtpropertyID.Text = .Item("PropertyID").ToString()
                    TxtAddress.Text = .Item("Address").ToString()
                    TxtMonthlyRent.Text = .Item("RentAmount").ToString()
                    TxtStatus.Text = .Item("Status").ToString()

                End With
            Else
                'Clears the fields
                TxtAddress.Clear()
                TxtMonthlyRent.Clear()
                TxtStatus.Clear()
                TxtpropertyID.Clear()

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            ' Validate inputs: Ensure all fields are filled, RentAmount is a valid number, and Type is selected
            If String.IsNullOrWhiteSpace(TxtAddress.Text) OrElse
           CmbPropertyType.SelectedValue Is Nothing OrElse
           String.IsNullOrWhiteSpace(TxtStatus.Text) OrElse
           Not Decimal.TryParse(TxtMonthlyRent.Text, Nothing) Then

                MessageBox.Show("Please ensure all fields are filled correctly, Rent Amount is a valid number or a property type is selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            ' Get selected TypeID from ComboBox
            Dim typeID As Integer = Convert.ToInt32(CmbPropertyType.SelectedValue)

            ' Get logged-in RealtorID
            Dim realtorID As Integer = Mainpage.LoggedInRealtorID

            ' Ask user if they want to add an image
            Dim result As DialogResult = MessageBox.Show("Do you want to add an image?", "Add Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Dim imagePath As String = ""

            If result = DialogResult.Yes Then
                Using openFileDialog As New OpenFileDialog()
                    openFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif"
                    openFileDialog.Title = "Select an Image"

                    If openFileDialog.ShowDialog() = DialogResult.OK Then
                        imagePath = openFileDialog.FileName
                        TxtImagePath.Text = imagePath ' Update the textbox to show the selected path
                    End If
                End Using
            End If

            ' Define the SQL query to insert a new property into the database
            Dim query As String = "INSERT INTO Properties (Address, Status, RentAmount,
                                   TypeID, ImagePath, RealtorID) " &
                                  "VALUES (@Address, @Status, @RentAmount, 
                                   @TypeID, @ImagePath, @RealtorID)"

            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Address", TxtAddress.Text)
                    cmd.Parameters.AddWithValue("@TypeID", typeID)
                    cmd.Parameters.AddWithValue("@Status", TxtStatus.Text)
                    cmd.Parameters.AddWithValue("@RentAmount", Convert.ToDecimal(TxtMonthlyRent.Text))
                    cmd.Parameters.AddWithValue("@ImagePath", If(imagePath <> "", imagePath, DBNull.Value.ToString())) ' Store the image path or NULL
                    cmd.Parameters.AddWithValue("@RealtorID", realtorID)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Property added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh the DataGridView to reflect the new record
            LoadData()

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtAddress.Clear()
        TxtStatus.Clear()
        TxtMonthlyRent.Clear()

        CmbPropertyType.SelectedIndex = -1

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ' Check if a row is selected
        If DgvProperties.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a property to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get selected property ID
        Dim selectedPropertyID As Integer = Convert.ToInt32(DgvProperties.CurrentRow.Cells("PropertyID").Value)

        ' Validate TypeID selection
        Dim typeID As Integer
        If CmbPropertyType.SelectedValue IsNot Nothing AndAlso Integer.TryParse(CmbPropertyType.SelectedValue.ToString(), typeID) Then
            ' TypeID is valid
        Else
            MessageBox.Show("Please select a valid property type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If



        ' Allow user to pick a new image
        Dim newImagePath As String = TxtImagePath.Text ' Keep current image if no change
        If MessageBox.Show("Do you want to change the property image?", "Change Image?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                newImagePath = OpenFileDialog1.FileName
                PicPropertyImage.Image = Image.FromFile(newImagePath) ' Show new image
                TxtImagePath.Text = newImagePath ' Update path
            End If
        End If

        ' Update query with proper Status and ImagePath handling
        Dim query As String = "UPDATE Properties SET Address = @Address, TypeID = @TypeID, 
                          [Status] = @Status, RentAmount = @RentAmount, ImagePath = @ImagePath 
                          WHERE PropertyID = @PropertyID"

        Try
            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    ' Assign parameters
                    cmd.Parameters.AddWithValue("@Address", TxtAddress.Text)
                    cmd.Parameters.AddWithValue("@TypeID", typeID)
                    cmd.Parameters.AddWithValue("@Status", TxtStatus.Text)
                    cmd.Parameters.AddWithValue("@RentAmount", Convert.ToDecimal(TxtMonthlyRent.Text))
                    cmd.Parameters.AddWithValue("@ImagePath", If(String.IsNullOrEmpty(newImagePath), DBNull.Value, newImagePath))
                    cmd.Parameters.AddWithValue("@PropertyID", selectedPropertyID)

                    ' Execute the update
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Success message
            MessageBox.Show("Property updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData() ' Refresh DataGridView
        Catch ex As Exception
            ' Show error message
            MessageBox.Show("Error updating property: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub BtnSearch_textChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        ' Get the search input
        Dim searchValue As String = TxtSearch.Text.Trim()



        Dim query As String = "SELECT p.*, pt.Description AS PropertyType " &
                      "FROM dbo.Properties p " &
                      "INNER JOIN dbo.PropertyType pt ON p.TypeID = pt.PropertyTypeID " &
                      "WHERE CAST(p.PropertyID AS NVARCHAR) LIKE @SearchValue OR " &
                      "p.Address LIKE @SearchValue OR " &
                      "pt.Description LIKE @SearchValue OR " &
                      "p.Status LIKE @SearchValue OR " &
                      "CAST(p.RentAmount AS NVARCHAR) LIKE @SearchValue"

        Using connection As SqlConnection = DBManager.GetConnection()
            Try
                Using cmd As New SqlCommand(query, connection)
                    ' Add parameter for search value with wildcard
                    cmd.Parameters.AddWithValue("@SearchValue", "%" & searchValue & "%")


                    ' Execute the query and fill the DataGridView
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    DgvProperties.DataSource = dt
                End Using
            Catch ex As Exception
                ' Handle exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure connection is closed
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Delete selected client

        Try
            ' Ensure a row is selected
            Dim selectedRow = DgvProperties.CurrentRow
            If selectedRow Is Nothing Then
                MessageBox.Show("Please select a record to delete.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Get the ClientID of the selected row
            Dim PropertyID As Integer = Convert.ToInt32(selectedRow.Cells("PropertyID").Value)

            ' Prompt the user for confirmation before deletion
            Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the property ID with ID {PropertyID}?",
                                                             "Confirm Delete",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Question)

            If confirmResult = DialogResult.Yes Then
                ' SQL query to delete the client from the database
                Dim deleteQuery As String = "DELETE FROM properties WHERE PropertyID = @PropertyID"

                ' Execute the deletion
                Using con As SqlConnection = DBManager.GetConnection()
                    Using cmd As New SqlCommand(deleteQuery, con)
                        cmd.Parameters.AddWithValue("@PropertyID", PropertyID)


                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        ' Check if the record was deleted
                        If rowsAffected > 0 Then
                            MessageBox.Show("PropertyID deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No record was deleted. Please try again.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using

                ' Refresh the DataGridView to reflect changes
                LoadData() ' This reloads the DataGridView with updated data
            End If
        Catch ex As Exception
            ' Handle any errors that occur during deletion
            MessageBox.Show($"An error occurred while deleting the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Function to delete a record
    Private Sub DgvProperties_SelectionChanged(sender As Object, e As EventArgs) Handles DgvProperties.SelectionChanged
        Try
            If DgvProperties.CurrentRow IsNot Nothing Then
                Dim imgPath As String = DgvProperties.CurrentRow.Cells("ImagePath").Value.ToString()

                ' Check if the file exists before loading it
                If IO.File.Exists(imgPath) Then
                    PicPropertyImage.Image = Image.FromFile(imgPath)
                Else
                    PicPropertyImage.Image = My.Resources._103500764_GettyImages_147205632_2 ' Default "No Image" placeholder
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnRemoveImage_Click(sender As Object, e As EventArgs) Handles BtnRemoveImage.Click
        ' Ask for confirmation before removing the image
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to remove this image?",
                                                        "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirmResult = DialogResult.Yes Then
            ' Clear the PictureBox and remove the image path
            PicPropertyImage.Image = My.Resources.NoImage1 ' Set to default image
            TxtImagePath.Text = ""

            ' Update database to remove image path for the selected property
            Dim query As String = "UPDATE Properties SET ImagePath = NULL
                                   WHERE PropertyID = @PropertyID"

            Try
                Using con As SqlConnection = DBManager.GetConnection()
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@PropertyID", TxtpropertyID.Text)


                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                LoadData()

                MessageBox.Show("Image removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error removing image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


End Class