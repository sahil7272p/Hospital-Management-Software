Public Class Login

    Public Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim user, pass As String
        user = txtusername.Text
        pass = txtpassword.Text
        If (user = "admin" And pass = "admin786") Then

            Me.Close()
            Home.Show()

        Else
            MsgBox("Invalid Credentials")
        End If

    End Sub

    Public Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()

    End Sub

    
End Class
