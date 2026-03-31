Imports System.Data.SqlClient
''' <summary>
''' This class deals with database access functions
''' </summary>
Public Class DBManager
    ''' <summary>
    ''' This function is called to connect the application to the database
    ''' </summary>
    ''' <returns>a connection object</returns>
    Public Shared Function GetConnection() As SqlConnection
        Dim constring As String = "Server=(local);Database=dbTenant;Trusted_Connection=True"
        Dim connection As New SqlConnection(constring)
        connection.Open()
        Return connection
    End Function

    ''' <summary>
    ''' This function loads a datatable for any general query
    ''' </summary>
    ''' <param name="selectQuery"></param>
    ''' <returns>a datatable</returns>
    Public Shared Function GetDataTable(selectQuery As String) As DataTable
        'create a command object with the query
        Dim cmd As New SqlCommand(selectQuery, GetConnection())
        'create a data adapter object
        Dim da As New SqlDataAdapter(cmd)
        'this is the result table
        Dim table As New DataTable
        da.Fill(table)
        Return table
    End Function
End Class