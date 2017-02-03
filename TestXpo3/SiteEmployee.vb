Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering
Public Class SiteEmployee
    Inherits XPObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    Private Property _nama As String
    Public Property nama As String
        Get
            Return _nama
        End Get
        Set(value As String)
            _nama = value
        End Set
    End Property

    Private Property _namasite As String
    Public Property namasite As String
        Get
            Return _namasite
        End Get
        Set(value As String)
            _namasite = value
        End Set
    End Property
End Class

