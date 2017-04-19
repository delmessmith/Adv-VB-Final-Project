
Public Class frmMileageTrackerNewEntry
    Private mMilesEntry As New MileageEntry

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim entryID As Integer = CInt(Now.Date)
        Dim entryDate As Date = CDate(dtpDate.Value)
        If mMilesEntry.Insert() Then
            Me.Close()
        Else
            lblStatus.Text = "Cannot Add Appointment. " & Appointments.LastError
        End If

        If chkGasPurchase.Checked Then
            frmGasTrackerNewEntry.ShowDialog()
        End If

        Me.Close()
    End Sub

    Private Sub frmMileageTrackerNewEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Housekeeping to clear any values
        txtBeginOdometer.Text = ""
        txtEndOdometer.Text = ""
        cboEmployee.Text = Username
        cboVehicle.Text = ""
        chkGasPurchase.Checked = False
        dtpDate.Text = Today

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class