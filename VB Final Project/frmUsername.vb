Public Class frmUsername
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim validUsername As Boolean = False

        Username = txtName.Text


        If Username = "" Then
            MessageBox.Show("You need to enter your name")
        Else
            validUsername = True
        End If

        If validUsername Then
            Me.Close()
        End If
    End Sub
End Class