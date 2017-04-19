﻿Public Class MileageEntry
    Private adapter As New GasPurchasesDataSetTableAdapters.MilesTableAdapter
    Public Shared Property LastError As String

    Public Function Insert(ByVal entryId As Integer, ByVal employee As String, ByVal vehicle As String, ByVal entryDate As Date, ByVal BeginOdometer As Integer,
                           ByVal endOdometer As Integer, ByVal miles As Integer) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(entryId, employee, vehicle, entryDate, BeginOdometer, endOdometer, miles)
            Return True
            MessageBox.Show(LastError)
        Catch ex As Exception
            LastError = ex.Message
            Return False
            MessageBox.Show(LastError)
        End Try
    End Function

End Class
