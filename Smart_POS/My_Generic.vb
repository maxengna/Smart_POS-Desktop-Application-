Imports System.Windows.Forms.Message

Public Class My_Generic(Of T)

    Private _value As T
    Private finalvalue As T


    Public Property data() As T
        Get
            Return _value
        End Get

        Set(ByVal value As T)
            _value = value

        End Set

    End Property

    'เช็ค value ว่าเป็น datatype > return

    Public Function Returntype(ByVal value As T)

        If TypeOf value Is String Then

            finalvalue = value

        ElseIf TypeOf value Is Integer Then

            finalvalue = value

        ElseIf TypeOf value Is Double Then

            finalvalue = value

        ElseIf TypeOf value Is Boolean Then

            finalvalue = value

        End If


        Return finalvalue

    End Function













End Class
