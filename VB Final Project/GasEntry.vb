Public Class GasEntry
    Private adapter As New GasPurchasesDataSetTableAdapters.GasTableAdapter
    Public Shared Property LastError As String

    Public Function Insert(ByVal employee As String, ByVal vehicle As String, ByVal entryDate As Date, ByVal purchaseAmnt As Double,
                           ByVal gasStation As String, ByVal receiptNumber As String) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(employee, vehicle, entryDate, purchaseAmnt, gasStation, receiptNumber)
            Return True
            MessageBox.Show(LastError)
        Catch ex As Exception
            LastError = ex.Message
            Return False
            MessageBox.Show(LastError)
        End Try
    End Function

    Public ReadOnly Property Items As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function Update(ByVal employee As String, ByVal vehicle As String, ByVal entryDate As Date, ByVal purchaseAmnt As Double,
                           ByVal gasStation As String, ByVal receiptNumber As String, ByVal entryId As Integer) As Boolean
        LastError = String.Empty
        Try
            adapter.Update(employee, vehicle, entryDate, purchaseAmnt, gasStation, receiptNumber, entryId)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function
    Public Function GetByDate(ByVal beginDate As Date, ByVal endDate As Date) As DataTable
        Dim table As DataTable = adapter.GetData
        table.DefaultView.RowFilter = "Date > #" & beginDate & "# and Date < #" & endDate & "#"
        Return table
    End Function
End Class
