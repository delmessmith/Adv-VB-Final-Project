﻿Option Strict On
Option Explicit On

Imports System.IO
Public Class frmGasReport
    Private mGasEntries As New GasEntry
    Dim reportRan As Boolean  'tells if a report has been ran in order for the data to be saved

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim beginDate As Date = CDate(dtpBegin.Text)
        Dim endDate As Date = CDate(dtpEnd.Text)

        If endDate < beginDate Then
            MessageBox.Show("End Date must be after Begin Date")
        Else

            dgvDisplay.DataSource = mGasEntries.GetByDate(beginDate, endDate)
            reportRan = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If reportRan Then
            Dim outfile As StreamWriter
            Dim strSaveFile As String

            sfdSave.ShowDialog() 'Display 'Save File' Form
            strSaveFile = sfdSave.FileName 'assign path to file

            outfile = File.CreateText(strSaveFile)
            outfile.WriteLine("Gas Entry ID,Employee,Vehicle,Date,Purchase Amount,Gas Station,Receipt Number")
            For Each row As DataGridViewRow In dgvDisplay.Rows
                If Not row.IsNewRow Then
                    outfile.WriteLine(row.Cells(0).Value.ToString & "," & row.Cells(1).Value.ToString & "," &
                                      row.Cells(2).Value.ToString & "," & row.Cells(3).Value.ToString & "," &
                                      row.Cells(4).Value.ToString & "," & row.Cells(5).Value.ToString & "," &
                                      row.Cells(6).Value.ToString)
                End If
            Next

            outfile.Close()
        Else
            MessageBox.Show("You must to select a date range to save a report")
        End If
    End Sub

    Private Sub frmGasReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reportRan = False
        dgvDisplay.DataSource = ""
    End Sub
End Class