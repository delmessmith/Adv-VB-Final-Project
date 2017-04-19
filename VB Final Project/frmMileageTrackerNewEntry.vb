
Public Class frmMileageTrackerNewEntry
    Private mMilesEntry As New MileageEntry

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim employee As String = Username
        Dim vehicle As String = cboVehicle.Text
        Dim entryDate As Date = CDate(dtpDate.Value)
        Dim beginOdom As Integer = CInt(txtBeginOdometer.Text)
        Dim endOdom As Integer = CInt(txtEndOdometer.Text)
        Dim miles As Integer = endOdom - beginOdom

        If mMilesEntry.Insert(employee, vehicle, entryDate, beginOdom, endOdom, miles) Then
            Me.Close()
        Else
            MessageBox.Show("Cannot Add Appointment. " & MileageEntry.LastError)
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