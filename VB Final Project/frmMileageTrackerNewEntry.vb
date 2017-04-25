
Public Class frmMileageTrackerNewEntry
    Private mMilesEntry As New MileageEntry

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim employee As String = Username
        Dim vehicle As String = cboVehicle.Text
        Dim entryDate As Date = CDate(dtpDate.Value)
        Dim beginOdom As Integer
        If txtBeginOdometer.Text = "" Then
            MessageBox.Show("Please enter a valid Beginning Odometer value")
            Return
        Else
            beginOdom = CInt(txtBeginOdometer.Text)
        End If

        Dim endOdom As Integer
        If txtEndOdometer.Text = "" Then
            MessageBox.Show("Please enter a valid Ending Odometer value")
            Return
        Else
            endOdom = CInt(txtEndOdometer.Text)
        End If
        Dim miles As Integer = endOdom - beginOdom

        If mMilesEntry.Insert(employee, vehicle, entryDate, beginOdom, endOdom, miles) Then
            If chkGasPurchase.Checked Then
                frmGasTrackerNewEntry.ShowDialog()
            End If
            Me.Close()
        Else
            MessageBox.Show("Cannot Add Appointment. " & MileageEntry.LastError)
        End If
    End Sub

    Private Sub frmMileageTrackerNewEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Housekeeping to clear any values
        txtBeginOdometer.Text = ""
        txtEndOdometer.Text = ""
        cboEmployee.Text = Username
        cboVehicle.SelectedIndex = 0
        chkGasPurchase.Checked = False
        dtpDate.Text = Today

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtBeginOdometer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBeginOdometer.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEndOdometer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEndOdometer.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class