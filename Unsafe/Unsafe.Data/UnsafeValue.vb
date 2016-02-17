
Public Class UnsafeValue

#Region " locals and such... "

    Private ReadOnly _UnsafeValue As Object = Nothing

#End Region

#Region " init "

    ''' <summary>
    ''' Creates a new UnsafeValue object
    ''' </summary>
    ''' <param name="Value">This is the unsanitized, potentially harmful data.</param>
    Sub New(ByRef Value As Object)
        _UnsafeValue = Value
    End Sub

#End Region

#Region " api - validate "

    ''' <summary>
    ''' Validate the unsafe value against the logic in T
    ''' </summary>
    ''' <typeparam name="T">Any object that inhertis from Unsafe.Data.UnsafeValidator.</typeparam>
    ''' <returns>Returns an instance of T, which validates the unsanitized data.</returns>
    Public Function Validate(Of T)() As T
        Dim targetType As Type = GetType(T)
        Dim baseType As Type = targetType.BaseType
        Dim requiredType As Type = GetType(Unsafe.Data.UnsafeValidator(Of))


        If targetType IsNot Nothing AndAlso IsSubclassOfRawGeneric(requiredType, targetType) Then
            Return Activator.CreateInstance(targetType, {_UnsafeValue})
        Else
            Throw New NotAnUnsafeValidatorException()
        End If

    End Function

#End Region

#Region " helpers -IsSubclassOfRawGeneric "

    Private Function IsSubclassOfRawGeneric(requiredGeneric As Type, testType As Type) As Boolean

        ' loop through each type, testing if it's the required generic type (note: the generic's target type doesn't matter)
        While (Not testType Is Nothing)
            If testType.IsGenericType AndAlso testType.GetGenericTypeDefinition() Is requiredGeneric Then
                Return True ' yep, found it
            End If

            ' not found it yet.. drop down one inheritance level 
            testType = testType.BaseType
        End While

        ' testType is null, which means we've inspected all of testType and not found the required generic type. return false
        Return False
    End Function



#End Region

End Class

