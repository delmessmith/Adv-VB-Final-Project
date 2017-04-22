Public Class MileageEntry
    Private adapter As New GasPurchasesDataSetTableAdapters.MilesTableAdapter
    Public Shared Property LastError As String

    Public Function Insert(ByVal employee As String, ByVal vehicle As String, ByVal entryDate As Date, ByVal BeginOdometer As Integer,
                           ByVal endOdometer As Integer, ByVal miles As Integer) As Boolean
        Try
            LastError = String.Empty
            adapter.Insert(employee, vehicle, entryDate, BeginOdometer, endOdometer, miles)
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

    Public Function Update(ByVal employee As String, ByVal vehicle As String, ByVal entryDate As Date, ByVal BeginOdometer As Integer,
                           ByVal endOdometer As Integer, ByVal miles As Integer, ByVal entryID As Integer) As Boolean
        LastError = String.Empty
        Try
            adapter.Update(employee, vehicle, entryDate, BeginOdometer, endOdometer, miles, entryID)
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
