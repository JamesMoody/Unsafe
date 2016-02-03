Imports System.Web.Mvc
Imports Unsafe.Data
Imports Unsafe.Data.Common.Validators
Imports Unsafe.Web

Namespace Controllers
    Public Class TestSet1Controller
        Inherits Controller

        Function TestId(testItem As UnsafeValue) As ActionResult

            If testItem.validate(Of valID).isValid Then
                Return New HttpStatusCodeResult(200)
            Else
                Return New HttpStatusCodeResult(500)
            End If


        End Function


        Function TestRawQS() As ActionResult

            If webValor.queryString("testItem").validate(Of valID).isValid Then
                Return New HttpStatusCodeResult(200)
            Else
                Return New HttpStatusCodeResult(500)
            End If


        End Function

    End Class

End Namespace