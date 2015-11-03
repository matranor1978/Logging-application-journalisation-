Imports System.ComponentModel

<Serializable()>
Public Class Entree

    Private _categorie As String
    Private _motscle As List(Of String)
    Private _date As Date
    Private _description As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal motscle As List(Of String))
        _motscle = motscle
    End Sub

    Public Sub New(ByVal categorie As String, ByVal motscle As List(Of String), ByVal dateActuelle As Date, ByVal description As String)
        _categorie = categorie
        _motscle = motscle
        _date = dateActuelle
        _description = description
    End Sub


    Public Property Categorie() As String
        Get
            Return _categorie
        End Get
        Set(ByVal value As String)
            _categorie = value
        End Set
    End Property



    Public Property MotsCle() As List(Of String)
        Get
            Return _motscle
        End Get
        Set(ByVal value As List(Of String))
            _motscle = value
        End Set
    End Property


    Public Property Dates() As Date
        Get
            Return _date
        End Get
        Set(ByVal value As Date)
            _date = value
        End Set
    End Property


    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Public Function CompareTo(ByVal obj As Object)
        Dim e As Entree = CType(obj, Entree)
        Return _motscle.SequenceEqual(e.MotsCle)
    End Function
End Class
