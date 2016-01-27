Imports System.Text.RegularExpressions

Namespace Common.Validators

    Public Class valSingleWord
        Inherits UnsafeValidator(Of String)

#Region " locals and such... "

        Private Const minLength As Integer = 1
        Private Const maxLength As Integer = 15 ' note: "<script></script>".length = 17... so a max lenth of 15 will prevent this attack. All known variants are even larger.

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
                       Regex.IsMatch(MyBase._unsafeValue, RegExStrings.Alpha)

            End Get
        End Property

#End Region

    End Class


End Namespace

