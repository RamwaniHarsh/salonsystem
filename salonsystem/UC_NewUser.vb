Imports MySql.Data.MySqlClient
Public Class UC_NewUser
    Private Sub btnAddNewUser_Click(sender As Object, e As EventArgs) Handles btnAddNewUser.Click
        AddUser()
    End Sub
    Private Sub AddUser()
        Try
            If txtNewUserPass.Text = txtconfirmpassword.Text Then


                Dim conn As New MySqlConnection("server=localhost;username=root;password=;database=salonsystem;port=3306")
                Dim cmd As MySqlCommand = New MySqlCommand("insert into Login values ('" & txtNewUserName.Text & "','" & txtconfirmpassword.Text & "','" & cmbsecurityquestion.Text & "','" & txtNewUserSecurAns.Text & "')")
                cmd.Connection = conn
                conn.Open()
                Dim r As Integer
                r = cmd.ExecuteNonQuery()
                If r > 0 Then
                    MsgBox("New User has been Saved!")
                Else
                    MsgBox("No record has been saved!")
                End If
                conn.Close()
            Else
                MsgBox("Password Does Not Matched")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub chkshowpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkshowpassword.CheckedChanged
        If chkshowpassword.Checked = True Then
            txtNewUserPass.PasswordChar = ""
            txtconfirmpassword.PasswordChar = ""
        End If
        If chkshowpassword.Checked = False Then
            txtNewUserPass.PasswordChar = "*"
            txtconfirmpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnNewUserClear_Click(sender As Object, e As EventArgs) Handles btnNewUserClear.Click
        txtconfirmpassword.Text = ""
        txtNewUserName.Text = ""
        txtNewUserPass.Text = ""
        txtNewUserSecurAns.Text = ""
        cmbsecurityquestion.SelectedIndex = -1
    End Sub

    Private Sub txtNewUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewUserName.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub
    Private Sub txtNewUserSecurAns_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewUserSecurAns.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            MessageBox.Show("You Can Enter Only Character!")
        End If
    End Sub

End Class
