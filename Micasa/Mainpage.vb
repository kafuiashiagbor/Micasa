Imports System.Data.SqlClient

Public Class Mainpage
    Friend Shared LoggedInRealtorID As Integer
    Friend Shared LoggedInRealtorName As String
    ' Load event to display welcome message
    Private Sub Mainpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Display Welcome Message
        LblWelcome.Text = "Welcome, " & LoggedInRealtorName & "!"

        ' Retrieve and display commission
        Dim commission As Decimal = GetAgentCommission(LoggedInRealtorID)
        LblCommissionEarned.Text = "Commission Earned: $" & commission.ToString("N2")


        LoadPropertyStats()

        LoadRentSummary()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnSales.Click
        Me.Hide()

        Dim Sales As New Sales
        Sales.Show()
    End Sub

    Private Sub BtnProperties_Click(sender As Object, e As EventArgs) Handles BtnProperties.Click
        Me.Hide()

        Dim properties As New Properties
        properties.Show()
    End Sub

    Private Sub BtnClients_Click(sender As Object, e As EventArgs) Handles BtnClients.Click
        Me.Hide()

        Dim clients As New Clients
        clients.Show()
    End Sub


    Private Sub LoadPropertyStats()
        Try
            ' Query to count sold, rented, managed, and available properties
            Dim Countquery As String = "SELECT 
                                    (SELECT COUNT(*) FROM Properties WHERE Status = 'Sold') AS TotalSold, 
                                    (SELECT COUNT(*) FROM Properties WHERE Status = 'Rented') AS TotalRented, 
                                    (SELECT COUNT(*) FROM Properties) AS TotalManaged,
                                    (SELECT COUNT(*) FROM Properties WHERE Status = 'Available') AS TotalAvailable"

            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(Countquery, con)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Display the values in labels
                            LblPropertySold.Text = "Total Properties Sold: " & reader("TotalSold").ToString()
                            LblPropertyRented.Text = "Total Properties Rented: " & reader("TotalRented").ToString()
                            LblPropertyManaged.Text = "Total Properties Managed: " & reader("TotalManaged").ToString()
                            LblAvailable.Text = "Total Properties Available: " & reader("TotalAvailable").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Display an error message if an exception occurs
            MessageBox.Show("Error loading property stats: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadRentSummary()
        Try
            ' Get total rent paid
            Dim queryPaid As String = "SELECT SUM(AmountPaid) AS TotalPaid FROM " &
                                       "RentPayments WHERE PaymentStatus = 'Paid'"
            Dim dtPaid As DataTable = DBManager.GetDataTable(queryPaid)

            If dtPaid.Rows.Count > 0 AndAlso Not IsDBNull(dtPaid.Rows(0)("TotalPaid")) Then
                LblTotalPaid.Text = "Total Rent Received: $" & dtPaid.Rows(0)("TotalPaid").ToString()
            Else
                LblTotalPaid.Text = "Total Rent Received: $0"
            End If

            ' Get total overdue rent
            Dim queryOverdue As String = "SELECT SUM(r.MonthlyRent) AS TotalOverdue " &
                                     "FROM Rentals r " &
                                     "JOIN RentPayments rp ON r.RentID = rp.RentID " &
                                     "WHERE rp.PaymentStatus = 'Overdue'"

            Dim dtOverdue As DataTable = DBManager.GetDataTable(queryOverdue)

            If dtOverdue.Rows.Count > 0 AndAlso Not IsDBNull(dtOverdue.Rows(0)("TotalOverdue")) Then
                LblTotalOverdue.Text = "Total Overdue Rent: $" & dtOverdue.Rows(0)("TotalOverdue").ToString()
            Else
                LblTotalOverdue.Text = "Total Overdue Rent: $0"
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading rent summary: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function GetAgentCommission(realtorID As Integer) As Decimal
        Dim commission As Decimal = 0
        Dim query As String = "SELECT SUM(SalePrice * 0.05) FROM Sales WHERE RealtorID = @RealtorID"

        Try
            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@RealtorID", realtorID)

                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        commission = Convert.ToDecimal(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving commission: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return commission
    End Function

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblCommissionEarned.Text = "Total Commission: $" & GetAgentCommission(LoggedInRealtorID).ToString("N2")
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()

        Dim logout As New FrmMain
        logout.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

        Dim rentals As New RentPayments
        rentals.Show()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim SaleReports As New SaleReports
        SaleReports.Show()

        Me.Hide()

    End Sub

    Private Sub BtnRentals_Click(sender As Object, e As EventArgs) Handles BtnRentals.Click
        Dim rentals As New Rentals
        rentals.Show()

        Me.Hide()

    End Sub
End Class