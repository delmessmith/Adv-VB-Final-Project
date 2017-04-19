Public Class Vehicles
    Dim mName As String
    Dim mID As Integer

    Public Property VehicleID As String
        Get
            VehicleID = mID
        End Get
        Set(value As String)
            mID = value
        End Set
    End Property

    Public Property Name As String
        Get
            Name = mName
        End Get
        Set(value As String)
            mName = value
        End Set
    End Property
End Class
