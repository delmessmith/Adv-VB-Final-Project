Public Class frmMain
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub mnuGasTrackerAddNew_Click(sender As Object, e As EventArgs) Handles mnuGasTrackerAddNew.Click
        frmGasTrackerNewEntry.ShowDialog()
    End Sub

    Private Sub mnuGasTrackerViewAll_Click(sender As Object, e As EventArgs) Handles mnuGasTrackerViewAll.Click
        frmGasTrackerViewAll.ShowDialog()
    End Sub

    Private Sub mnuMileTrackerAddNew_Click(sender As Object, e As EventArgs) Handles mnuMileTrackerAddNew.Click
        frmMileageTrackerNewEntry.ShowDialog()
    End Sub

    Private Sub mnuMileTrackerViewAll_Click(sender As Object, e As EventArgs) Handles mnuMileTrackerViewAll.Click
        frmMileageTrackerViewAll.ShowDialog()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub GenerateReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GenerateReportToolStripMenuItem1.Click
        frmMileageReport.ShowDialog()
    End Sub

    Private Sub GenerateReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateReportToolStripMenuItem.Click
        frmGasReport.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmUsername.ShowDialog()

        If Username = "" Then
            Me.Close()
        End If
    End Sub
End Class
