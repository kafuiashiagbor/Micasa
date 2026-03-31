Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Data



Public Class Clients

    Private dtClients As New DataTable()


    ' Load data on form load
    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientData()
        BindClientFields()
    End Sub


    ' Load client data into DataGridView
    Private Sub LoadClientData()
        Try
            Dim query As String = "SELECT ClientID, Name, Email, Address, DateOfBirth FROM Clients"

            dtClients = New DataTable()
            Using con As SqlConnection = DBManager.GetConnection()

                Using adapter As New SqlDataAdapter(query, con)
                    dtClients.Clear() ' Clear DataTable before reloading
                    adapter.Fill(dtClients)
                End Using
            End Using

            bsClients.DataSource = dtClients
            DgvClients.DataSource = Nothing ' Reset DataGridView to force refresh
            DgvClients.DataSource = bsClients

            ' Force UI update
            DgvClients.Refresh()
            DgvClients.Update()

        Catch ex As Exception
            MessageBox.Show("Error loading clients data: " & ex.Message & vbCrLf & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Add a new client
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            Dim query As String = "INSERT INTO Clients (Name, Email, Address, DateOfBirth) VALUES (@Name, @Email, @Address, @DateOfBirth)"

            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = TxtName.Text
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = TxtEmail.Text
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = TxtAddress.Text
                    cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = DtpDateOfBirth.Value.Date

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Client added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadClientData() ' Ensure the DataGridView reloads

        Catch ex As Exception
            MessageBox.Show("Error adding client: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try
    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ' Ensures that a row is selected
        If DgvClients.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a client to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'This line of code retrives the client id
        Dim selectedClientID As Integer = Convert.ToInt32(DgvClients.CurrentRow.Cells("ClientID").Value)

        Dim query As String = "UPDATE Clients SET Name = @Name, Address = @Address, DateOfBirth = @DOB, Email = @Email WHERE ClientID = @ClientID"

        Try
            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    ' Assign values from input fields
                    cmd.Parameters.AddWithValue("@Name", TxtName.Text)
                    cmd.Parameters.AddWithValue("@Address", TxtAddress.Text)
                    cmd.Parameters.AddWithValue("@DOB", DtpDateOfBirth.Value)
                    cmd.Parameters.AddWithValue("@Email", TxtEmail.Text)
                    cmd.Parameters.AddWithValue("@ClientID", selectedClientID)
                    ' Execute update
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            LoadClientData() ' Refresh DataGridView
            MessageBox.Show("Client updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error updating client: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Delete selected client

        Try
            ' Ensure a row is selected
            Dim selectedRow = DgvClients.CurrentRow
            If selectedRow Is Nothing Then
                MessageBox.Show("Please select a record to delete.", "No Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Get the ClientID of the selected row
            Dim clientID As Integer = Convert.ToInt32(selectedRow.Cells("ClientID").Value)

            ' Prompt the user for confirmation before deletion
            Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the client with ID {clientID}?",
                                                             "Confirm Delete",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Question)

            If confirmResult = DialogResult.Yes Then
                ' SQL query to delete the client from the database
                Dim deleteQuery As String = "DELETE FROM Clients WHERE ClientID = @ClientID"

                ' Execute the deletion
                Using con As SqlConnection = DBManager.GetConnection()
                    Using cmd As New SqlCommand(deleteQuery, con)
                        cmd.Parameters.AddWithValue("@ClientID", clientID)


                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        ' Check if the record was deleted
                        If rowsAffected > 0 Then
                            MessageBox.Show("Client deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("No record was deleted. Please try again.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                End Using

                ' Refresh the DataGridView to reflect changes
                LoadClientData() ' This reloads the DataGridView with updated data
            End If
        Catch ex As Exception
            ' Handle any errors that occur during deletion
            MessageBox.Show($"An error occurred while deleting the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Try

            ' This retrieve data from the search box and the filter ready to be used for search
            Dim searchTerm As String = TxtSearch.Text.Trim()

            ' Performing a join again to make sure all the fields apper during the search
            Dim query As String = "SELECT ClientID, Name, DateOfBirth, Address, Email FROM Clients " &
                                  "WHERE ClientID LIKE @SearchTerm OR Name LIKE @SearchTerm OR " &
                                  "DateOfBirth LIKE @SearchTerm OR Address LIKE @SearchTerm OR Email LIKE @SearchTerm " &
                                  "ORDER BY Name"

            ' This executes the search query
            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")


                    ' When the process is done, the block of code loads results into DataGridView
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    DgvClients.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred while searching for the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs)

        ' Reload all data into the DataGridView
        LoadClientData()
        ' Clear the search text
        TxtSearch.Clear()

    End Sub

    Private Sub BtnMainpage_Click(sender As Object, e As EventArgs) Handles BtnMainpage.Click
        Me.Hide()

        Dim mainpage As New Mainpage

        mainpage.Show()
    End Sub
    Private Sub BindClientFields()
        ' Clear any previous bindings
        TxtName.DataBindings.Clear()
        TxtEmail.DataBindings.Clear()
        TxtAddress.DataBindings.Clear()
        DtpDateOfBirth.DataBindings.Clear()

        ' Ensure bsClients has data before binding
        If bsClients.DataSource IsNot Nothing Then
            TxtName.DataBindings.Add("Text", bsClients, "Name")
            TxtEmail.DataBindings.Add("Text", bsClients, "Email")
            TxtAddress.DataBindings.Add("Text", bsClients, "Address")
            DtpDateOfBirth.DataBindings.Add("Value", bsClients, "DateOfBirth")
        Else
            MessageBox.Show("No data found to bind!", "Binding Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtName.Clear()
        TxtAddress.Clear()
        TxtEmail.Clear()

        ' Reset the DateTimePicker to the current date/time
        DtpDateOfBirth.Value = DateTime.Now
    End Sub

End Class