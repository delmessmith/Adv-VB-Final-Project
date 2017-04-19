Public Class frmMileageTrackerViewAll
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub frmMileageTrackerViewAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GasPurchasesDataSet.Miles' table. You can move, or remove it, as needed.
        Me.MilesTableAdapter.Fill(Me.GasPurchasesDataSet.Miles)

    End Sub
End Class