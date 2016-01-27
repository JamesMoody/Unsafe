'Namespace UnsafeData


'    Public Class UnsafeValue

'        Private _UnsafeValue As Object = Nothing


'        Sub New(ByRef Value As Object)
'            _UnsafeValue = Value
'        End Sub

'        Public Function validate(Of T)() As T
'            Dim targetType As Type = GetType(T)
'            Dim baseType As Type = targetType.BaseType


'            If baseType.Namespace = "WebApplication1.UnsafeData" AndAlso baseType.Name = "UnsafeValidator`1" Then
'                Return Activator.CreateInstance(targetType, {_UnsafeValue})
'            Else
'                Throw New NotAnUnsafeValidatorException()
'            End If
'        End Function

'    End Class


'End Namespace
