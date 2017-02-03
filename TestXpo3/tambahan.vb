Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering

Public Class tambahan
    Inherits XPObject

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    Private Property _testing1 As String
    Public Property testing1 As String
        Get
            Return _testing1
        End Get
        Set(value As String)
            _testing1 = value
        End Set
    End Property

    Private Property _testing2 As String

    Public Property testing2 As String
        Get
            Return _testing2
        End Get
        Set(value As String)
            _testing2 = value
        End Set
    End Property

End Class
