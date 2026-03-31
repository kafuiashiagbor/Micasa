Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Net


Public Class Rentals
    Private Sub Loadrentals()
        Try
            Dim query As String = "SELECT r.rentID, c.Name, r.LeaseStarttDate, r.LeaseEndDate, r.MonthlyRent, r.paymentStatus, a.RealtorName, r.PropertyID " &
                                  "From Rentals as r, Clients as c, Agents as a " &
                                  "WHERE r.clientID = C.ClientID and a.RealtorID = r.realtorID "

            Dim dt As DataTable = DBManager.GetDataTable(query)
            DgvRentals.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading rentals: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CmbPropertyType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPropertyType.SelectedIndexChanged
        If CmbPropertyType.SelectedIndex <> -1 Then
            LoadAvailableProperties(CmbPropertyType.SelectedItem.ToString())
        End If
    End Sub


    Private Sub LoadAvailableProperties(propertyType As String)
        Try
            ' SQL query to fetch available property IDs of the selected type
            Dim query As String = "SELECT p.PropertyID " &
                              "FROM Properties p " &
                              "INNER JOIN PropertyType pt ON p.TypeID = pt.PropertyTypeID " &
                              "WHERE pt.Description = @PropertyType AND p.Status = 'Available'"

            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@PropertyType", propertyType)

                    Dim dt As New DataTable()
                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)

                    ' Bind available properties to combo box
                    CmbPropertyID.DataSource = dt
                    CmbPropertyID.DisplayMember = "PropertyID" ' Shows only Property ID
                    CmbPropertyID.ValueMember = "PropertyID"   ' Stores Property ID as value
                    CmbPropertyID.SelectedIndex = -1 ' Ensure nothing is selected initially
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

    Private Sub UpdatePropertyStatus(propertyID As Integer)
        Try
            'this query updated the now sold property form availiable to sold
            Dim query As String = "UPDATE Properties SET Status = 'Rented' WHERE PropertyID = @PropertyID"

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

        Dim propertyID As Integer
        If CmbPropertyID.SelectedItem IsNot Nothing Then
            propertyID = Convert.ToInt32(DirectCast(CmbPropertyID.SelectedValue, Object))
        Else
            MessageBox.Show("Please select a valid Property ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Query to get the amount (Sale Price or Rent Amount) based on Property ID
            Dim query As String = "SELECT RentAmount FROM Properties WHERE PropertyID = @PropertyID"

            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@PropertyID", propertyID)


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

    Private Sub Rentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cquery As String = "SELECT ClientID, Name FROM Clients"
        CmbClientName.DataSource = DBManager.GetDataTable(cquery)

        Loadrentals()
    End Sub

    Private Sub DgvRentals_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRentals.CellClick
        ' Ensure a valid row is selected
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DgvRentals.Rows(e.RowIndex)

            ' Get Client Name from DataGridView
            Dim clientName As String = selectedRow.Cells("Name").Value.ToString()
            CmbClientName.SelectedIndex = CmbClientName.FindStringExact(clientName)

            ' Get Property ID from DataGridView and set it in the ComboBox
            Dim propertyID As Integer = Convert.ToInt32(selectedRow.Cells("PropertyID").Value)
            CmbPropertyID.SelectedValue = propertyID

            ' Assign values from DataGridView to respective controls
            DtpStartDate.Value = Convert.ToDateTime(selectedRow.Cells("LeaseStarttDate").Value)
            DtpEndDate.Value = Convert.ToDateTime(selectedRow.Cells("LeaseEndDate").Value)
            TxtAmount.Text = selectedRow.Cells("MonthlyRent").Value.ToString()
            CmbPaymentStatus.SelectedItem = selectedRow.Cells("PaymentStatus").Value.ToString()
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            ' Validate required fields


            ' Fetch data from form
            Dim rentID As Integer = CInt(DgvRentals.SelectedRows(0).Cells("RentID").Value)
            Dim clientID As Integer = CInt(CmbClientName.SelectedValue)
            Dim propertyID As Integer = CInt(CmbPropertyID.SelectedValue)
            Dim startDate As Date = DtpStartDate.Value
            Dim endDate As Date = DtpEndDate.Value
            Dim paymentStatus As String = CmbPaymentStatus.SelectedItem.ToString()

            ' Auto-flag overdue rentals
            If endDate < DateTime.Now And paymentStatus = "Pending" Then
                paymentStatus = "Overdue"
            End If

            ' SQL Update Query
            Dim query As String = "UPDATE Rentals SET ClientID = @ClientID, PropertyID = @PropertyID, " &
                              "LeaseStarttDate = @StartDate, LeaseEndDate = @EndDate, PaymentStatus = @PaymentStatus " &
                              "WHERE RentID = @RentID"

            ' Execute SQL Command
            Using conn As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RentID", rentID)
                    cmd.Parameters.AddWithValue("@ClientID", clientID)
                    cmd.Parameters.AddWithValue("@PropertyID", propertyID)
                    cmd.Parameters.AddWithValue("@StartDate", startDate)
                    cmd.Parameters.AddWithValue("@EndDate", endDate)

                    cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Rental updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh DataGridView
            Loadrentals()

        Catch ex As Exception
            MessageBox.Show("Error updating rental: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            ' Ensure required fields are selected/entered
            If CmbClientName.SelectedIndex = -1 Or CmbPropertyID.SelectedIndex = -1 Then
                MessageBox.Show("Please select both a Client and a Property.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim propertyID As Integer
            If CmbPropertyID.SelectedItem IsNot Nothing Then
                propertyID = Convert.ToInt32(DirectCast(CmbPropertyID.SelectedValue, Object))
            Else
                MessageBox.Show("Please select a valid Property ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            ' Fetch data from form
            Dim clientID As Integer = CInt(CmbClientName.SelectedValue)  ' Get selected client ID

            Dim startDate As Date = DtpStartDate.Value
            Dim endDate As Date = DtpEndDate.Value
            Dim amount As Decimal = CDec(TxtAmount.Text)
            Dim paymentStatus As String = "Pending" ' Default status

            ' Ensure Realtor ID is correctly fetched
            Dim realtorID As Integer = Mainpage.LoggedInRealtorID ' Must be set when logging in

            ' SQL Transaction: Insert rental & update property status
            Dim queryRental As String = "INSERT INTO Rentals (ClientID, PropertyID, LeaseStarttDate, LeaseEndDate, MonthlyRent, PaymentStatus, RealtorID) " &
                                        "VALUES (@ClientID, @PropertyID, @StartDate, @EndDate, @Amount, @PaymentStatus, @RealtorID)"

            Dim queryUpdateProperty As String = "UPDATE Properties SET Status = 'Rented' WHERE PropertyID = @PropertyID"

            Using conn As SqlConnection = DBManager.GetConnection()
                Using trans As SqlTransaction = conn.BeginTransaction()
                    Try
                        ' Insert rental
                        Using cmd As New SqlCommand(queryRental, conn, trans)
                            cmd.Parameters.AddWithValue("@ClientID", clientID)
                            cmd.Parameters.AddWithValue("@PropertyID", propertyID)
                            cmd.Parameters.AddWithValue("@StartDate", startDate)
                            cmd.Parameters.AddWithValue("@EndDate", endDate)
                            cmd.Parameters.AddWithValue("@Amount", amount)
                            cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus)
                            cmd.Parameters.AddWithValue("@RealtorID", realtorID)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Update property status
                        Using cmd As New SqlCommand(queryUpdateProperty, conn, trans)
                            cmd.Parameters.AddWithValue("@PropertyID", propertyID)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Commit transaction
                        trans.Commit()
                        MessageBox.Show("Rental added successfully, and property marked as 'Rented'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        MessageBox.Show("Rental record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        trans.Rollback()
                        MessageBox.Show("Error adding rental: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using

            ' Refresh Data
            LoadRentals()
            LoadAvailableProperties(CmbPropertyType.SelectedItem.ToString())


        Catch ex As Exception
            MessageBox.Show("Error adding rental: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            ' Ensure a rental is selected
            If DgvRentals.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a rental to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Fetch rental details
            Dim rentID As Integer = CInt(DgvRentals.SelectedRows(0).Cells("RentID").Value)
            Dim propertyID As Integer = CInt(DgvRentals.SelectedRows(0).Cells("PropertyID").Value)

            ' SQL Transaction: Delete rental & update property status
            Dim queryDeleteRental As String = "DELETE FROM Rentals WHERE RentID = @RentID"
            Dim queryUpdateProperty As String = "UPDATE Properties SET Status = 'Available' WHERE PropertyID = @PropertyID"

            Using conn As SqlConnection = DBManager.GetConnection()
                Using trans As SqlTransaction = conn.BeginTransaction()
                    Try
                        ' Delete rental
                        Using cmd As New SqlCommand(queryDeleteRental, conn, trans)
                            cmd.Parameters.AddWithValue("@RentID", rentID)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Update property status
                        Using cmd As New SqlCommand(queryUpdateProperty, conn, trans)
                            cmd.Parameters.AddWithValue("@PropertyID", propertyID)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Commit transaction
                        trans.Commit()
                        MessageBox.Show("Rental deleted, and property marked as 'Available'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        trans.Rollback()
                        MessageBox.Show("Error deleting rental: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using

            ' Refresh Data
            Loadrentals()
            LoadAvailableProperties(CmbPropertyType.SelectedItem.ToString()) ' Reload only available properties

        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        ' Get the search input
        Dim searchValue As String = TxtSearch.Text.Trim()

        ' If the search box is empty, reload all records
        If String.IsNullOrWhiteSpace(searchValue) Then
            Loadrentals()
            Return
        End If

        Dim query As String = "SELECT r.RentID, c.Name AS ClientName, a.RealtorName, " &
                      "r.MonthlyRent, r.LeaseStarttDate, r.LeaseEndDate, r.PaymentStatus " &
                      "FROM Rentals r " &
                      "JOIN Clients c ON r.ClientID = c.ClientID " &
                      "JOIN Agents a ON r.RealtorID = a.RealtorID " &
                      "WHERE (c.Name LIKE @SearchValue OR a.RealtorName LIKE @SearchValue)"



        Try
            Using connection As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, connection)
                    ' Add search parameter with wildcard for flexible search
                    cmd.Parameters.AddWithValue("@SearchValue", "%" & searchValue & "%")

                    ' Execute query and update DataGridView
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    DgvRentals.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            ' Show error message
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnMainPage_Click(sender As Object, e As EventArgs) Handles BtnMainPage.Click
        Me.Hide()

        Dim mainpage As New Mainpage
        mainpage.Show()

    End Sub
End Class