Imports System.ComponentModel

<Serializable()>
Public Class Type

    Private _extension As String
    Private _motsCle As New List(Of String)
    Private _categories As New List(Of String)

    Public Sub New()

    End Sub

    Public Sub New(ByVal extension As String, ByVal motsCle As List(Of String), ByVal _categories As List(Of String))
        _extension = extension
        _motsCle = motsCle
        _categories = Categories
    End Sub

    Public Property Extension() As String
        Get
            Return _extension
        End Get
        Set(ByVal value As String)
            _extension = value
        End Set
    End Property



    Public Property MotsCle() As List(Of String)
        Get
            Return _motsCle
        End Get
        Set(ByVal value As List(Of String))
            _motsCle = value
        End Set
    End Property



    Public Property Categories() As List(Of String)
        Get
            Return _categories
        End Get
        Set(ByVal value As List(Of String))
            _categories = value
        End Set
    End Property


End Class
