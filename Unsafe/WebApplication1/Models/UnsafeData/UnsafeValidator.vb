'Namespace UnsafeData


'    Public MustInherit Class UnsafeValidator(Of T)

'#Region " locals and such... "

'        Protected _unsafeValue As Object = Nothing
'        Protected _defaultValue As T = Nothing

'#End Region

'#Region " init - new (object) "

'        Sub New(ByVal rawValue As Object)
'            _unsafeValue = rawValue
'        End Sub

'#End Region
'#Region " init - new (object, T) "

'        Sub New(ByVal value As Object, [default] As T)
'            _unsafeValue = value
'            _defaultValue = [default]
'        End Sub

'#End Region

'#Region " api - value "

'        Public Function value() As T
'            If isValid() Then
'                Return _unsafeValue
'            Else
'                Return _defaultValue
'            End If
'        End Function

'#End Region

'#Region " MustOverride - isValid "

'        Public MustOverride ReadOnly Property isValid() As Boolean

'#End Region

'    End Class

'End Namespace
