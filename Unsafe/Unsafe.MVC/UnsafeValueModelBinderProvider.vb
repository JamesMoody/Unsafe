Public Class UnsafeValueModelBinderProvider
    Implements IModelBinderProvider

    Public Function GetBinder(modelType As Type) As IModelBinder Implements IModelBinderProvider.GetBinder
        If (modelType = GetType(UnsafeValue)) Then
            Return New UnsafeValueModelBinder()
        End If

        Return Nothing
    End Function
End Class
