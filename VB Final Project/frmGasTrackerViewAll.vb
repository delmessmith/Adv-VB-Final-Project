Public Class frmGasTrackerViewAll
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub frmGasTrackerViewAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GasPurchasesDataSet.Gas' table. You can move, or remove it, as needed.
        Me.GasTableAdapter.Fill(Me.GasPurchasesDataSet.Gas)

    End Sub
End Class