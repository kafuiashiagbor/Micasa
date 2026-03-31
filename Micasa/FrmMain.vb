Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FrmMain


    'This function computes the MD5  hash of the raw password
    Public Function ComputeMD5Hash(input As String) As String
        Using md5 As MD5 = MD5.Create()
            'this cinverts the input string onto a bite arrayusing the UTF8 encoding
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
            'This computes the hash of the byte array
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)
            'Defining sb as a string builder to stor the hex values
            Dim sb As New StringBuilder()

            For Each b As Byte In hashBytes
                ' Convert byte to hex. It ensures that the hex representation is always in 2 digits
                'This ensures that the hash is readerable
                sb.Append(b.ToString("x2"))
            Next
            'Returns the hashed function
            Return sb.ToString()
        End Using
    End Function


    ' Function for login




    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim username As String = TxtUsername.Text.Trim()
        Dim password As String = TxtPassword.Text.Trim()

        ' Ensure username is not an integer
        If IsNumeric(username) Then
            MessageBox.Show("Username cannot be a number or contain a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Ensure password is at least 8 characters long
        If password.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Hash the input password to compare with stored hash
        Dim hashedInput As String = ComputeMD5Hash(password)

        ' Query to get both RealtorID and RealtorName
        Dim query As String = "SELECT RealtorID, RealtorName FROM Agents WHERE Username = @Username AND PasswordHash = @PasswordHash"

        Try
            Using con As SqlConnection = DBManager.GetConnection()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@PasswordHash", hashedInput)


                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    ' Check if a matching user exists
                    If reader.Read() Then
                        Mainpage.LoggedInRealtorID = Convert.ToInt32(reader("RealtorID")) ' Assign RealtorID to Global Variable
                        Mainpage.LoggedInRealtorName = reader("RealtorName").ToString() ' Assign RealtorName to Global Variable

                        ' Debugging message to confirm correct login
                        MessageBox.Show("Logged in RealtorID: " & Mainpage.LoggedInRealtorID.ToString() & vbCrLf & "Realtor Name: " & Mainpage.LoggedInRealtorName)

                        ' Open main dashboard
                        Dim dashboard As New Mainpage()
                        dashboard.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub LLabelRedirect_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lblsignup.LinkClicked
        Me.Hide()

        Dim signup As New Frmsignup
        signup.Show()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class