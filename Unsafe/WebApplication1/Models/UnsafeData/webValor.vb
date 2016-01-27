'Namespace UnsafeData

'    Public Class webValor

'#Region " api - queryString (int) "

'        Public Shared Function queryString(ByVal index As Integer) As UnsafeValue
'            Return New UnsafeValue(HttpContext.Current.Request.QueryString(index))
'        End Function

'#End Region
'#Region " api - queryString (string) "

'        Public Shared Function queryString(ByVal key As String) As UnsafeValue
'            Dim val As String = HttpContext.Current.Request.QueryString(key)
'            Return New UnsafeValue(val)
'        End Function

'#End Region

'#Region " api - form (int) "

'        Public Shared Function form(ByVal index As Integer) As UnsafeValue
'            Return New UnsafeValue(HttpContext.Current.Request.Form(index))
'        End Function

'#End Region
'#Region " api - form (string) "

'        Public Shared Function form(ByVal key As String) As UnsafeValue
'            Return New UnsafeValue(HttpContext.Current.Request.Form(key))
'        End Function

'#End Region

'    End Class

'End Namespace
