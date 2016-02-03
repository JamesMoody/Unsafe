Namespace Common


    Public Class RegExStrings

        ''' <summary>
        ''' English only Alpha Check
        ''' </summary>
        ''' <remarks></remarks>
        Public Const Alpha As String = "^[a-zA-Z]+$"

        ''' <summary>
        ''' Numeric check
        ''' </summary>
        ''' <remarks></remarks>
        Public Const Numeric As String = "^[0-9]+$"

        ''' <summary>
        ''' English Alpha-Numeric check
        ''' </summary>
        ''' <remarks></remarks>
        Public Const AlphaNumeric As String = "^[a-zA-Z0-9]+$"

        ''' <summary>
        ''' English Alpha-Numeric + space check
        ''' </summary>
        ''' <remarks></remarks>
        Public Const AlphaNumericSpace As String = "^[a-zA-Z0-9 ]+$"

        ''' <summary>
        ''' English only typeable letters
        ''' </summary>
        ''' <remarks>WARNING: This is wide enough to allow some common attacks.</remarks>
        Public Const AlphaNumericSymbolic As String = "^[" + "a-zA-Z0-9" + _
                                                             "`~!@#\$%\^&*\(\)_-\+=" + _
                                                             "\{\}" + _
                                                             "\[\]" + _
                                                             "\|\\" + _
                                                             ";:" + _
                                                             "\'""" + _
                                                             ",/\?" + _
                                                             "/</>" + _
                                                             " " + _
                                                             "]+$" ' !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST TEST 

        ''' <summary>
        ''' Typical, English only single-line comments
        ''' </summary>
        ''' <remarks></remarks>
        Public Const SimpleComment As String = "^[a-zA-Z0-9 \.!\?]+$"

        ''' <summary>
        ''' Typical, English only multi-line comments
        ''' </summary>
        ''' <remarks></remarks>
        Public Const MultilineComment As String = "^[a-zA-Z0-9 \.!\?\r\n]+$"

        ''' <summary>
        ''' BBCode Check
        ''' </summary>
        ''' <remarks>This DOES NOT parse BBCode, just whitelists all possible characters.</remarks>
        Public Const BBCode As String = "^[a-zA-Z0-9\[\]]+$" ' !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW REVIEW

    End Class

End Namespace
