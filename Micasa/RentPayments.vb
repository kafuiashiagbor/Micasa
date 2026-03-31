Imports System.Data.SqlClient
Imports System.IO

Public Class RentPayments
    Private Sub CmbPaymentFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPaymentStatus.SelectedIndexChanged
        Dim selectedFilter As String = CmbPaymentStatus.SelectedItem.ToString()
        LoadRentPayments(selectedFilter)
    End Sub

    Private Sub DgvRentPayments_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DgvRentPayments.DataError
        ' Prevent crashes by handling invalid conversions
        e.ThrowException = False
    End Sub

    Private Sub Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate Payment Status ComboBox
        CmbPaymentStatus.Items.Clear()
        CmbPaymentStatus.Items.Add("All")        ' Show all payments
        CmbPaymentStatus.Items.Add("Paid")       ' Show only paid rent
        CmbPaymentStatus.Items.Add("Overdue")    ' Show overdue rent
        CmbPaymentStatus.SelectedIndex = 0       ' Default to "All"

        FormatPaymentRow()
        FormatPaymentRows()
    End Sub

    Private Sub FormatPaymentRow()
        For Each row As DataGridViewRow In DgvRentPayments.Rows
            If Not row.IsNewRow Then
                Dim status As String = row.Cells("PaymentStatus").Value.ToString()

                ' If status is Overdue, show "Null" instead of Amount
                If status = "Overdue" Then
                    row.Cells("AmountPaid").Value = DBNull.Value
                End If
            End If
        Next
    End Sub

    Private Sub LoadRentPayments(filterStatus As String)
        Try
            ' SQL query with COALESCE to show 0 if payment is overdue
            Dim query As String = "SELECT rp.PaymentID, c.Name AS ClientName, p.PropertyID, " &
                              "rp.PaymentDate, COALESCE(rp.AmountPaid, 0) AS AmountPaid, rp.PaymentStatus " &
                              "FROM RentPayments rp " &
                              "JOIN Rentals r ON rp.RentID = r.RentID " &
                              "JOIN Clients c ON r.ClientID = c.ClientID " &
                              "JOIN Properties p ON r.PropertyID = p.PropertyID"

            ' Apply filter conditions based on selection
            If filterStatus = "Paid" Then
                query &= " WHERE rp.PaymentStatus = 'Paid'"
            ElseIf filterStatus = "Overdue" Then
                query &= " WHERE rp.PaymentStatus = 'Overdue'"
            End If

            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)

                    ' Execute query and bind results to DataGridView
                    Dim dt As New DataTable()
                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                    DgvRentPayments.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading rent payments: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FormatPaymentRows()
        For Each row As DataGridViewRow In DgvRentPayments.Rows
            If Not row.IsNewRow Then
                Dim status As String = row.Cells("PaymentStatus").Value.ToString()

                Select Case status
                    Case "Paid"
                        row.DefaultCellStyle.BackColor = Color.LightGreen ' 🟢 Green
                    Case "Overdue"
                        row.DefaultCellStyle.BackColor = Color.LightCoral ' 🔴 Red
                    Case Else
                        row.DefaultCellStyle.BackColor = Color.White ' Default White
                End Select
            End If
        Next
    End Sub



    Private Sub AutoFlagOverdueRentals()
        Try
            ' SQL query to update rentals to "Overdue" if not paid by lease start date
            Dim query As String = "UPDATE Rentals SET PaymentStatus = 'Overdue' " &
                                  "WHERE LeaseStartDate < @Today AND PaymentStatus != 'Paid'"

            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Today", DateTime.Now.Date)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating overdue rentals: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnMainpage_Click(sender As Object, e As EventArgs) Handles BtnMainpage.Click
        Me.Hide()

        Dim mainpage As New Mainpage
        mainpage.Show()
    End Sub


End Class