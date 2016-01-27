Imports System.Text.RegularExpressions

Namespace Common.Validators


    Public Class valText
        Inherits UnsafeValidator(Of String)

#Region " locals and such... "

        Private Const minLength As Integer = 1
        Private Const maxLength As Integer = 1000 ' NOTE: This is large enough to contain attacks!

#End Region

#Region " inits "

        Sub New(ByRef value As Object)
            MyBase.New(value, String.Empty)
        End Sub

#End Region

#Region " Overrides - isValid "
        Public Overrides ReadOnly Property isValid As Boolean
            Get

                Return TypeOf MyBase._unsafeValue Is String AndAlso _
                       Not String.IsNullOrWhiteSpace(MyBase._unsafeValue) AndAlso _
                       DirectCast(MyBase._unsafeValue, String).Length >= minLength AndAlso _
                       DirectCast(MyBase._unsafeValue, String).Length <= maxLength AndAlso _
                       Regex.IsMatch(MyBase._unsafeValue, RegExStrings.AlphaNumericSymbolic)
            End Get
        End Property

#End Region

    End Class


End Namespace
