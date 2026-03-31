Imports System.Data.SqlClient

Public Class Sale_reports

    Private Sub LoadSaleReport()
        Dim SaleReport As String = "Select" &
                                    "From Sales"

    End Sub


    Private Sub LoadRealtorName()
        Dim query As String = "SELECT RealtorID, RealtorName FROM Agents"
        Dim adapter As New SqlDataAdapter(query, DBManager.GetConnection())
        Dim table As New DataTable()
        adapter.Fill(table)

        CmbRealtorName.DataSource = table
        CmbRealtorName.DisplayMember = "RealtorName"
        CmbRealtorName.ValueMember = "RealtorID"

    End Sub



    Private Sub Sale_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRealtorName()

    End Sub
End Class