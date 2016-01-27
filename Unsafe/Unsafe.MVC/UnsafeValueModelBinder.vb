Public Class UnsafeValueModelBinder
    Implements IModelBinder

    Public Function BindModel(controllerContext As ControllerContext, bindingContext As ModelBindingContext) As Object Implements IModelBinder.BindModel
        Dim request = controllerContext.HttpContext.Request
        Dim name = bindingContext.ModelName
        Return New UnsafeValue(request(name))
    End Function
End Class
