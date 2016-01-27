Imports Unsafe.Web
Imports Unsafe.Data
Imports Unsafe.Data.Common.Validators



Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Private ReadOnly EvenTestArray() As Integer = {2, 4, 6, 8, 10, 12, 14, 16, 18, 20}

    Function Index() As ActionResult

        Dim data As New mdlTestPageStuff()

        '?query=${eval(base64_decode('echo'2q4mnj3hg6mngfh''));}

        '?query=$%7Beval(base64_decode(%27ZWNobycycTRtbmozaGc2bW5nZmgnOw==%27));%7D
        '$%7Beval(base64_decode(%27ZWNobycycTRtbmozaGc2bW5nZmgnOw==%27));%7D
        '${eval(base64_decode('ZWNobycycTRtbmozaGc2bW5nZmgnOw=='));}
        'decoded = "echo'2q4mnj3hg6mngfh';"



        '       Dim bs() As Byte = Convert.FromBase64String("ZWNobycycTRtbmozaGc2bW5nZmgnOw==")
        '       Dim decoded As String = Encoding.UTF8.GetString(bs)


        'data.Tests.Add(New NameValuePair() With {.Name = "test 1.a", .Value = String.Format("does ?test= exist? {0}", webValor.queryString("test").validate(Of valSingleWord)().isValid)})
        'data.Tests.Add(New NameValuePair() With {.Name = "test 1.b", .Value = String.Format("?test={0}", webValor.queryString("test").validate(Of valSingleWord)().value)})

        'data.Tests.Add(New NameValuePair() With {.Name = "test 2.a", .Value = String.Format("does ?id= exist? {0}", webValor.queryString("id").validate(Of valID)().isValid)})
        'data.Tests.Add(New NameValuePair() With {.Name = "test 2.b", .Value = String.Format("?id={0}", webValor.queryString("id").validate(Of valID)().value)})

        'Dim test3 As New UnsafeValue("some data item")
        'data.Tests.Add(New NameValuePair() With {.Name = "test 3.a", .Value = String.Format("is '{1}' text? {0}", test3.validate(Of valText)().isValid, test3.validate(Of valText)().value)})
        'data.Tests.Add(New NameValuePair() With {.Name = "test 3.b", .Value = String.Format("is '{1}' an id? {0}", test3.validate(Of valID)().isValid, test3.validate(Of valID)().value)})
        'data.Tests.Add(New NameValuePair() With {.Name = "test 3.c", .Value = String.Format("is '{1}' word? {0}", test3.validate(Of valSingleWord)().isValid, test3.validate(Of valSingleWord)().value)})

        'Dim test6 As New UnsafeValue("somedataitem")
        'data.Tests.Add(New NameValuePair() With {.Name = "test 4.a", .Value = String.Format("is '{1}' text? {0}", test6.validate(Of valText)().isValid, test6.validate(Of valText)().value)})
        'data.Tests.Add(New NameValuePair() With {.Name = "test 4.b", .Value = String.Format("is '{1}' an id? {0}", test6.validate(Of valID)().isValid, test6.validate(Of valID)().value)})
        'data.Tests.Add(New NameValuePair() With {.Name = "test 4.c", .Value = String.Format("is '{1}' word? {0}", test6.validate(Of valSingleWord)().isValid, test6.validate(Of valSingleWord)().value)})

        'Dim test4 As New UnsafeValue("12345")
        'data.Tests.Add(New NameValuePair() With {.Name = "test 5.a", .Value = String.Format("is '{1}' text? {0}", test4.validate(Of valText)().isValid, test4.validate(Of valText)().value)})
        'data.Tests.Add(New NameValuePair() With {.Name = "test 5.b", .Value = String.Format("is '{1}' an id? {0}", test4.validate(Of valID)().isValid, test4.validate(Of valID)().value)})

        'Dim test5 As New UnsafeValue(12345)
        'data.Tests.Add(New NameValuePair() With {.Name = "test 6.a", .Value = String.Format("is '{1}' text? {0}", test5.validate(Of valText)().isValid, test5.validate(Of valText)().value)})
        'data.Tests.Add(New NameValuePair() With {.Name = "test 6.b", .Value = String.Format("is '{1}' an id? {0}", test5.validate(Of valID)().isValid, test5.validate(Of valID)().value)})

        'Dim tmp(EvenTestArray.Length - 1) As Integer
        'EvenTestArray.CopyTo(tmp, 0)
        'Array.Reverse(tmp)
        'data.Tests.Add(New NameValuePair() With {.Name = "test 7.a", .Value = String.Format("is '{0}' in '{1}'? {2}", 10, tmp, valor.isIn(10, tmp))})

        ''        Dim test8 As New UnsafeValue(12345)
        ''        data.Tests.Add(New NameValuePair() With {.Name = "test 8.a", .Value = String.Format("this should always fail: {0}", test8.validate(Of Object)().isValid)})

        'Dim test9 As New UnsafeValue(Nothing)
        'data.Tests.Add(New NameValuePair() With {.Name = "test 9.a", .Value = String.Format("this should always fail: {0}", test9.validate(Of valID)().isValid)})

        'Dim test10 As New UnsafeValue("adsF")
        'data.Tests.Add(New NameValuePair() With {.Name = "test 10.a", .Value = String.Format("this should always fail: {0}", test10.validate(Of valAlwaysPassInteger)().value)})

        Return View(data)
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function


    Function thingie(test1 As UnsafeValue, test2 As UnsafeValue)
        Dim test1Result = test1.validate(Of valID).isValid
        Dim test2Result = test2.validate(Of valID).isValid

        Return View(test1Result)
    End Function

End Class


#Region " helpers classes - valAlwaysPassInteger"

Public Class valAlwaysPassInteger
    Inherits UnsafeValidator(Of Integer)

    Sub New(ByRef value As Object)
        MyBase.New(value)
    End Sub


    Public Overrides ReadOnly Property isValid As Boolean
        Get
            Return True
        End Get
    End Property

End Class

#End Region