Imports System.Data.SqlClient
Imports System.Net
Imports System.Security.Cryptography


Public Class Sales
    ' Load sales records from the database
    Private salestable As New System.Data.DataTable

    Private Sub SaleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim cquery As String = "SELECT ClientID, Name FROM Clients"
        CmbClientName.DataSource = DBManager.GetDataTable(cquery)

        LoadSales()
    End Sub


    Private Sub LoadSales()
        Try
            Dim query As String = "SELECT s.SaleID, c.Name, s.saleDate, s.SalePrice, s.PaymentMethod, a.RealtorName, s.PropertyID  " &
                                  "FROM Sales as s, Clients as c, Agents as a " &
                                  "WHERE s.ClientID = c.ClientID and a.realtorID = s.realtorID  "


            Dim cmd As New SqlCommand(query, DBManager.GetConnection())
            Dim da As New SqlDataAdapter(cmd)
            'this is the result table
            salestable.Rows.Clear()
            da.Fill(salestable)

            DgvSales.DataSource = salestable
            DgvSales.ForeColor = Color.Black
        Catch ex As Exception
            MessageBox.Show("Error loading sales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Load selected sale into form fields
    Private Sub BtnMainPage_Click(sender As Object, e As EventArgs) Handles BtnMainPage.Click
        Me.Hide()

        Dim mainpage As New Mainpage
        mainpage.Show()

    End Sub



    Private Sub LoadAvailableProperties(propertyType As String)
        Try
            ' SQL query to get only available properties of the selected type
            Dim query As String = "SELECT p.PropertyID " &
                              "FROM Properties p " &
                              "INNER JOIN PropertyType pt ON p.TypeID = pt.PropertyTypeID " &
                              "WHERE pt.Description = @PropertyType AND p.Status = 'Available'"

            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@PropertyType", propertyType)


                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    ' Clear Property ID dropdown before loading new data
                    CmbPropertyID.Items.Clear()

                    ' Add only available property IDs
                    While reader.Read()
                        CmbPropertyID.Items.Add(reader("PropertyID").ToString())
                    End While

                    reader.Close()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading available properties: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetPropertyStatus(propertyID As Integer) As String
        Dim status As String = ""
        Dim query As String = "SELECT Status FROM Properties WHERE PropertyID = @PropertyID"

        Try
            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@PropertyID", propertyID)


                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        status = result.ToString()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error retrieving property status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return status
    End Function


    Private Sub CmbPropertyType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPropertyType.SelectedIndexChanged
        Dim selectedType As String = CmbPropertyType.SelectedItem.ToString()
        LoadAvailableProperties(selectedType)
    End Sub


    Private Sub UpdatePropertyStatus(propertyID As Integer)
        Try
            'this query updated the now sold property form availiable to sold
            Dim query As String = "UPDATE Properties SET Status = 'Sold' WHERE PropertyID = @PropertyID"

            'Fecthing the connection string from dbmanager
            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@PropertyID", propertyID)

                    'executes the query in the database
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            'error messgae showing that the record could no be updated
            MessageBox.Show("Error updating property status: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbPropertyID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPropertyID.SelectedIndexChanged
        ' Ensure a property is selected
        If CmbPropertyID.SelectedIndex = -1 Then Exit Sub

        ' Get the selected Property ID
        Dim selectedPropertyID As Integer = Convert.ToInt32(CmbPropertyID.SelectedItem)

        Try
            ' Query to get the amount (Sale Price or Rent Amount) based on Property ID
            Dim query As String = "SELECT RentAmount FROM Properties WHERE PropertyID = @PropertyID"

            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@PropertyID", selectedPropertyID)


                    Dim result As Object = cmd.ExecuteScalar()

                    ' If a value is found, display it in TxtAmount
                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        TxtAmount.Text = Convert.ToDecimal(result).ToString("N2") ' Format as currency
                    Else
                        TxtAmount.Text = "0.00" ' Default value if no amount is found
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading amount: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        ' Validate Inputs
        If CmbClientName.SelectedIndex = -1 OrElse CmbPropertyID.SelectedIndex = -1 OrElse
       String.IsNullOrWhiteSpace(TxtAmount.Text) OrElse CmbPaymentMethod.SelectedIndex = -1 OrElse
       CmbPropertyType.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields before adding the sale.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get selected values
        Dim clientID As Integer = Convert.ToInt32(CmbClientName.SelectedValue) ' Get Client id from the selceted Name
        Dim propertyType As String = CmbPropertyType.SelectedItem.ToString() ' Get Property Type
        Dim propertyID As Integer = Convert.ToInt32(CmbPropertyID.SelectedItem) ' Get Property ID
        Dim saleDate As Date = DtpSaleDate.Value ' Get Sale Date
        Dim paymentMethod As String = CmbPaymentMethod.SelectedItem.ToString() ' Get Payment Method
        Dim realtorID As Integer = Mainpage.LoggedInRealtorID ' Auto-assign the logged-in Realtor

        ' Ensure Sale Price is valid
        Dim salePrice As Decimal
        If Not Decimal.TryParse(TxtAmount.Text, salePrice) OrElse salePrice <= 0 Then
            MessageBox.Show("Invalid sale price. Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If



        ' SQL Query to Insert Sale & Update Property Status
        Dim insertSaleQuery As String = "INSERT INTO Sales (ClientID, PropertyID, SaleDate, SalePrice, PaymentMethod, RealtorID) " &
                                    "VALUES (@ClientID, @PropertyID, @SaleDate, @SalePrice, @PaymentMethod, @RealtorID)"

        'SQL query to update the property status to sold when the property has been sold
        Dim updatePropertyQuery As String = "UPDATE Properties SET Status = 'Sold' WHERE PropertyID = @PropertyID"

        Try
            Using con As SqlConnection = DBManager.GetConnection()

                Dim transaction As SqlTransaction = con.BeginTransaction() ' Start Transaction

                Try
                    ' This line of code inserts the Sale
                    Using cmd As New SqlCommand(insertSaleQuery, con, transaction)
                        cmd.Parameters.AddWithValue("@ClientID", clientID)
                        cmd.Parameters.AddWithValue("@PropertyID", propertyID)
                        cmd.Parameters.AddWithValue("@SaleDate", saleDate)
                        cmd.Parameters.AddWithValue("@SalePrice", salePrice)
                        cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod)
                        cmd.Parameters.AddWithValue("@RealtorID", realtorID)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Update Property Status to 'Sold'
                    Using cmd As New SqlCommand(updatePropertyQuery, con, transaction)
                        cmd.Parameters.AddWithValue("@PropertyID", propertyID)
                        cmd.ExecuteNonQuery()
                    End Using

                    transaction.Commit() ' Commit Transaction

                    MessageBox.Show("Sale successfully added! Property status updated to Sold.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Refresh DataGridView & Available Properties
                    LoadSales()
                    LoadAvailableProperties(CmbPropertyType.SelectedItem.ToString())

                Catch ex As Exception

                    transaction.Rollback() ' Rollback on error

                    MessageBox.Show("Error adding sale: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        ' Ensure a sale row is selected in DgvSales
        If DgvSales.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a sale record before making changes.", "No Sale Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate Inputs
        If CmbClientName.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(TxtAmount.Text) OrElse
       CmbPaymentMethod.SelectedIndex = -1 Then
            MessageBox.Show("Please fill in all fields before updating the sale.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim saleID As Integer = Convert.ToInt32(DgvSales.CurrentRow.Cells("SaleID").Value)

        ' Confirm Update
        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to update this sale?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult <> DialogResult.Yes Then Return ' Exit if user cancels

        ' Get selected values

        Dim clientID As Integer = Convert.ToInt32(CmbClientName.SelectedValue)
        Dim saleDate As Date = DtpSaleDate.Value
        Dim paymentMethod As String = CmbPaymentMethod.SelectedItem.ToString()


        ' Ensure Sale Price is valid
        Dim salePrice As Decimal
        If Not Decimal.TryParse(TxtAmount.Text, salePrice) OrElse salePrice <= 0 Then
            MessageBox.Show("Invalid sale price. Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' SQL Query to Update Sale
        Dim updateQuery As String = "UPDATE Sales SET ClientID = @ClientID, SaleDate = @SaleDate, SalePrice = @SalePrice, PaymentMethod = @PaymentMethod WHERE SaleID = @SaleID"

        Try
            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(updateQuery, con)
                    cmd.Parameters.AddWithValue("@ClientID", clientID)
                    cmd.Parameters.AddWithValue("@SaleDate", saleDate)
                    cmd.Parameters.AddWithValue("@SalePrice", salePrice)
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod)
                    cmd.Parameters.AddWithValue("@SaleID", saleID)



                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Sale updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh Sales DataGridView
            LoadSales()

        Catch ex As Exception
            MessageBox.Show("Error updating sale: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgvSales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSales.CellClick
        ' Ensure a valid row is selected
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DgvSales.Rows(e.RowIndex)

            ' Get ClientName from DataGridView
            Dim clientName As String = selectedRow.Cells("Name").Value.ToString()

            ' Find and set the corresponding ClientID in the ComboBox
            CmbClientName.SelectedIndex = CmbClientName.FindStringExact(clientName)



            ' Assign ClientID to the ComboBox value
            DtpSaleDate.Value = Convert.ToDateTime(selectedRow.Cells("SaleDate").Value)
            TxtAmount.Text = selectedRow.Cells("SalePrice").Value.ToString()
            CmbPaymentMethod.SelectedItem = selectedRow.Cells("PaymentMethod").Value.ToString()
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Ensure a sale is selected
        If DgvSales.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a sale record to delete.", "No Sale Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected SaleID
        Dim selectedRow As DataGridViewRow = DgvSales.SelectedRows(0)
        Dim saleID As Integer = Convert.ToInt32(selectedRow.Cells("SaleID").Value)

        ' Confirm before deletion
        Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this sale?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmDelete = DialogResult.No Then
            Return
        End If

        ' Execute DELETE query
        Dim deleteQuery As String = "DELETE FROM Sales WHERE SaleID = @SaleID"

        Try
            Using con As SqlConnection = DBManager.GetConnection()

                Using cmd As New SqlCommand(deleteQuery, con)
                    cmd.Parameters.AddWithValue("@SaleID", saleID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Notify the user
            MessageBox.Show("Sale deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh the DataGridView
            LoadSales()

        Catch ex As Exception
            MessageBox.Show("Error deleting sale: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        ' Get the search input
        Dim searchValue As String = TxtSearch.Text.Trim()

        ' If the search box is empty, reload all records
        If String.IsNullOrWhiteSpace(searchValue) Then
            LoadSales()
            Return
        End If

        ' Updated SQL query to search by Client Name and Payment Method
        Dim query As String = "SELECT s.SaleID, c.Name AS Name, s.SaleDate, s.SalePrice, " &
                              "s.PaymentMethod, a.RealtorName, s.PropertyID " &
                              "FROM Sales s " &
                              "JOIN Clients c ON s.ClientID = c.ClientID " &
                              "JOIN Agents a ON s.RealtorID = a.RealtorID " &
                              "WHERE c.Name LIKE @SearchValue OR s.PaymentMethod LIKE @SearchValue"

        Try
            Using connection As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, connection)
                    ' Add search parameter with wildcard for flexible search
                    cmd.Parameters.AddWithValue("@SearchValue", "%" & searchValue & "%")

                    ' Execute query and update DataGridView
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    DgvSales.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            ' Show error message
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
End Class