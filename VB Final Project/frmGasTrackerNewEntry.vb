Option Strict On
Option Explicit On


Imports System.IO
Public Class frmGasTrackerNewEntry
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        MessageBox.Show("Successfully Added to Database")
        Me.Close()
    End Sub

    Private Sub frmGasTrackerNewEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Housekeeping to clear any values
        txtPurchaseAmnt1.Text = ""
        txtGasStation.Text = ""
        txtReceiptNumber.Text = ""
        cboEmployee.Text = Username
        cboVehicle.Text = ""
        dtpDate.Text = Today.ToString
    End Sub

    Private Sub txtPurchaseAmnt_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class