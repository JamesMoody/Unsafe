'Imports Unsafe.Data

'Namespace bizLib.validators


'    Public Class valID
'        Inherits UnsafeValidator(Of Integer)

'#Region " locals and such... "

'        Private Const minValue As Integer = 0
'        Private Const maxValue As Integer = Integer.MaxValue

'#End Region

'#Region " inits "

'        Sub New(ByVal value As Object)
'            MyBase.New(value, 42)
'        End Sub
'        Sub New(ByVal value As Object, [default] As Integer)
'            MyBase.New(value, [default])
'        End Sub

'#End Region

'#Region " Overrides - isValid "

'        Public Overrides ReadOnly Property isValid As Boolean
'            Get
'                Dim result As Integer = 0

'                If TypeOf MyBase._unsafeValue Is Integer AndAlso _
'                   valor.isBetween(MyBase._unsafeValue, minValue, maxValue) Then

'                    Return True


'                ElseIf TypeOf MyBase._unsafeValue Is String AndAlso _
'                       Integer.TryParse(MyBase._unsafeValue, result) AndAlso _
'                       valor.isBetween(result, minValue, maxValue) Then

'                    Return True


'                Else
'                    Return False
'                End If

'            End Get
'        End Property

'#End Region

'    End Class


'End Namespace

