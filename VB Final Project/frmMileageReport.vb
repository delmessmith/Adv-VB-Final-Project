Option Explicit On
Option Strict On

Imports System.IO
Public Class frmMileageReport

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        MessageBox.Show(dtpBegin.Text.ToString)

        Dim outfile As StreamWriter
        'outfile = File.AppendText(sfdSave)

        'outfile.WriteLine(txtCourseNumber.Text & "," &
        '                  txtCourseName.Text & "," &
        '                  cboCredits.Text)
        'outfile.Close()
    End Sub
End Class