
Public Class UnsafeValue

#Region " locals and such... "

    Private ReadOnly _UnsafeValue As Object = Nothing

#End Region

#Region " init "

    Sub New(ByRef Value As Object)
        _UnsafeValue = Value
    End Sub

#End Region

#Region " api - validate "

    Public Function validate(Of T)() As T
        Dim targetType As Type = GetType(T)
        Dim baseType As Type = targetType.BaseType


        If baseType IsNot Nothing AndAlso baseType.Namespace = "Unsafe.Data" AndAlso baseType.Name = "UnsafeValidator`1" Then
            Return Activator.CreateInstance(targetType, {_UnsafeValue})
        Else
            Throw New NotAnUnsafeValidatorException()
        End If
    End Function

#End Region


End Class

