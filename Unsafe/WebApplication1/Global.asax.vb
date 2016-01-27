﻿Imports System.Web.Optimization

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

        '        ModelBinderProviders.BinderProviders.Add(New UnsafeValueParameterBinderProvider())
        ModelBinderProviders.BinderProviders.Add(New Unsafe.MVC.UnsafeValueModelBinderProvider())

    End Sub
End Class
