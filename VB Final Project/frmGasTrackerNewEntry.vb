Option Strict On
Option Explicit On


Imports System.IO
Public Class frmGasTrackerNewEntry
    Private mGasEntry As New GasEntry
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim employee As String = Username
        Dim vehicle As String = cboVehicle.Text
        Dim entryDate As Date = CDate(dtpDate.Value)
        Dim purchaseAmnt As Double
        If txtPurchaseAmnt.Text = "   ." Then
            MessageBox.Show("Please enter a valid Purchase Amount")
            Return
        Else
            purchaseAmnt = CDbl(txtPurchaseAmnt.Text)
        End If

        Dim gasStation As String
        If txtGasStation.Text = "" Then
            MessageBox.Show("Please enter a valid Gas Station")
            Return
        Else
            gasStation = txtGasStation.Text
        End If

        Dim receiptNumber As String
        If txtReceiptNumber.Text = "" Then
            MessageBox.Show("Please enter a valid Receipt Number")
            Return
        Else
            receiptNumber = txtReceiptNumber.Text
        End If

        If mGasEntry.Insert(employee, vehicle, entryDate, purchaseAmnt, gasStation, receiptNumber) Then
            Me.Close()
        Else
            MessageBox.Show("Cannot Add Appointment. " & GasEntry.LastError)
        End If
    End Sub

    Private Sub frmGasTrackerNewEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Housekeeping to clear any values
        txtPurchaseAmnt.Text = ""
        txtGasStation.Text = ""
        txtReceiptNumber.Text = ""
        cboEmployee.Text = Username
        cboVehicle.SelectedIndex = 0
        dtpDate.Text = Today.ToString

    End Sub

    Private Sub txtPurchaseAmnt_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
End Class