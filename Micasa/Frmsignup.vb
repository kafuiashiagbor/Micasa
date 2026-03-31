Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Frmsignup
    ' Function to() hash password
    Public Function ComputeMD5Hash(input As String) As String
        Using md5 As MD5 = MD5.Create()
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)
            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2")) ' Convert byte to hex
            Next
            Return sb.ToString()
        End Using
    End Function

    ' Function to check if a string contains numbers
    Private Function ContainsNumbers(input As String) As Boolean
        Return input.Any(Function(c) Char.IsDigit(c))
    End Function
    ' Function to register a new realtor
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = TxtUsername.Text.Trim()
        Dim password As String = TxtPassword.Text.Trim()
        Dim name As String = TxtName.Text.Trim() ' Retrieve Name
        Dim email As String = TxtEmail.Text.Trim()


        ' Ensure username and password are not empty
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ensure password is at least 8 characters long
        If password.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate username (no numbers allowed)
        If ContainsNumbers(username) Then
            MessageBox.Show("Username cannot contain numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        ' Hash the password using MD5
        Dim hashedPassword As String = ComputeMD5Hash(password)

        ' Check if username already exists
        Dim checkQuery As String = "SELECT COUNT(*) FROM Agents WHERE Username = @Username"
        Dim insertQuery As String = "INSERT INTO Agents (RealtorName, Email, Username, PasswordHash) VALUES (@Name, @Email, @Username, @PasswordHash)"

        Try
            Using con As SqlConnection = DBManager.GetConnection()
                Using checkCmd As New SqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@Username", username)


                    Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())


                    ' If username exists, show error
                    If count > 0 Then
                        MessageBox.Show("Username already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    ' Insert new user
                    Using insertCmd As New SqlCommand(insertQuery, con)
                        insertCmd.Parameters.AddWithValue("@Username", username)
                        insertCmd.Parameters.AddWithValue("@PasswordHash", hashedPassword)
                        insertCmd.Parameters.AddWithValue("@Name", name)
                        insertCmd.Parameters.AddWithValue("@Email", email)


                        insertCmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Hide()
                    Dim login As New FrmMain
                    FrmMain.Show()

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during registration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Frmsignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class