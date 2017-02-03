Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class Site
    Inherits XPObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    Private _namasite As String
    Public Property namasite As String
        Get
            Return _namasite
        End Get
        Set(value As String)
            _namasite = value
        End Set
    End Property
End Class
