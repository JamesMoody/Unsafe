'Imports Unsafe.Data

'Namespace bizLib.validators


'    Public Class valText
'        Inherits UnsafeValidator(Of String)

'#Region " inits "

'        Sub New(ByVal value As Object)
'            MyBase.New(value)
'        End Sub
'        Sub New(ByVal value As Object, [default] As String)
'            MyBase.New(value, [default])
'        End Sub

'#End Region

'#Region " Overrides - isValid "
'        Public Overrides ReadOnly Property isValid As Boolean
'            Get
'                Return TypeOf MyBase._unsafeValue Is String AndAlso _
'                       Not String.IsNullOrWhiteSpace(MyBase._unsafeValue) AndAlso _
'                       DirectCast(MyBase._unsafeValue, String).Length > 4 AndAlso _
'                       DirectCast(MyBase._unsafeValue, String).Length < 50
'            End Get
'        End Property

'#End Region

'    End Class


'End Namespace
