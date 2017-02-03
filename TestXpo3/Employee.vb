Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Public Class Employee
    Inherits XPObject

    Public Sub New(Session As Session)
        MyBase.New(Session)
    End Sub

    Private _nama As String

    Public Property nama As String
        Get
            Return _nama
        End Get
        Set(value As String)
            _nama = value
        End Set
    End Property

    Private _umur As String
    Public Property Umur As String
        Get
            Return _umur
        End Get
        Set(value As String)
            _umur = value
        End Set
    End Property


End Class
