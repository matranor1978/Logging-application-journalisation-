Imports System.ComponentModel

<Serializable()>
Public Class Journal
    Private _type As Type
    Private _entrees As List(Of Entree)

    Public Sub New()

    End Sub

    Public Sub New(ByRef entrees As List(Of Entree))
        _entrees = entrees

    End Sub

    Public Sub New(ByRef type As Type)
        _type = type

    End Sub

    Public Property Entrees() As List(Of Entree)
        Get
            Return _entrees
        End Get
        Set(ByVal value As List(Of Entree))
            _entrees = value
        End Set
    End Property

    Public Property Type() As Type
        Get
            Return _type
        End Get
        Set(ByVal value As Type)
            _type = value
        End Set
    End Property



End Class

