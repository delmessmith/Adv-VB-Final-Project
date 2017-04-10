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
        txtPurchaseAmnt.Text = ""
        txtGasStation.Text = ""
        txtReceiptNumber.Text = ""
        cboEmployee.Text = Username
        cboVehicle.Text = ""
        dtpDate.Text = Today.ToString
    End Sub
End Class