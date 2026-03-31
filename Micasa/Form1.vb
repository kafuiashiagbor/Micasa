Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBManager.GetConnection()
        MsgBox("Connection to the DB successfull")
    End Sub
End Class
