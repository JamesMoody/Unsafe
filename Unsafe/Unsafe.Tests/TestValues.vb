Public Class TestValues


    ' references:
    ' http://demo.icu-project.org/icu-bin/convexp
    ' UTF-8: http://demo.icu-project.org/icu-bin/convexp?conv=UTF-8&s=ALL
    '
    ' https://en.wikipedia.org/wiki/UTF-8
    ' https://en.wikipedia.org/wiki/Character_encodings_in_HTML 
    ' https://en.wikipedia.org/wiki/Unicode_and_HTML
    '
    ' https://en.wikipedia.org/wiki/Percent-encoding
    '
    ' https://en.wikipedia.org/wiki/List_of_XML_and_HTML_character_entity_references
    '
    ' https://en.wikipedia.org/wiki/Unicode
    ' 
    ' https://en.wikipedia.org/wiki/Miscellaneous_Symbols
    '
    ' https://en.wikipedia.org/wiki/Emoji
    '



    Public Shared ReadOnly SequentialTestArray() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
    Public Shared ReadOnly EvenTestArray() As Integer = {2, 4, 6, 8, 10, 12, 14, 16, 18, 20}


    Public Const String_SingleWord As String = "Word"
    Public Const String_MultiWordNoSpace As String = "SomeWordBHereButItNeedsToBeReallyReallyLongSomeWordBHereButItNeedsToBeReallyReallyLongSomeWordBHereButItNeedsToBeReallyReallyLong"
    Public Const String_MultiWord As String = "Word B Here"
    Public Const String_WordAndNumber As String = "Word8Here"
    Public Const String_Integer As String = "123456"
    Public Const String_Integer_Neg As String = "-123456"
    Public Const String_Decimal As String = "123.456"
    Public Const String_Decimal_Neg As String = "-123.456"

    Public Const Attack_ScriptTag As String = "<script></script>"
    Public Const Attack_SimpleAlert As String = "<script>alert('XSS')</script>"
    Public Const Attach_ScriptAlertFullyEncoded As String = "%3c%73%63%72%69%70%74%3e%61%6c%65%72%74%28%60%78%73%73%60%29%3c%2f%73%63%72%69%70%74%3e" '<script>alert('xss')</script>
    Public Const Attack_ScriptTagOpen As String = "<script>"
    Public Const Attack_ScriptInProperty As String = "javascript:alert('XSS');"
    Public Const Attack_ScriptInProperty_Spaced As String = "jav   ascript:alert('XSS');"
    Public Const Attack_ScriptInProperty_uniEncoded As String = "jav&#x09;ascript:alert('XSS');"
    Public Const Attack_ScriptInProperty_Quoted As String = """" + Attack_ScriptInProperty + """"
    Public Const Attack_ScriptInProperty_Quoted_Spaced As String = """" + Attack_ScriptInProperty_Spaced + """"
    Public Const Attack_ScriptInProperty_Quoted_uniEncoded As String = """" + Attack_ScriptInProperty_uniEncoded + """"

    Public Const Integer_Neg1 As Integer = -1
    Public Const Integer_Zero As Integer = 0
    Public Const Integer_Test As Integer = 10
    Public Const Integer_TestHigh As Integer = 100
    Public Const Integer_TestLow As Integer = -100
    Public Const Integer_MaxValue As Integer = Integer.MaxValue
    Public Const Integer_MinValue As Integer = Integer.MinValue
    Public Const Integer_StringTestValue As Integer = 123456

    Public Const Decimal_TestValue As Decimal = 123.456

    Public Const SafeBadGuySite_URL As String = "NeverGoToThisSite.net"
    Public Const SafeBadGuySite_HTTP As String = "http://" + SafeBadGuySite_URL
    Public Const SafeBadBuySite_HTTPEncoded As String = "http%3A%2F%2Fwww." + SafeBadGuySite_URL

    Public Const Comment_Statement As String = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
    Public Const Comment_Sentences As String = "Pellentesque facilisis quis tellus in pharetra. Integer tristique pellentesque risus, at congue lorem egestas eget. Duis ipsum nunc, auctor non porttitor vel, iaculis ac lacus."
    Public Const Comment_Paragraph As String = "Suspendisse potenti. Duis quis sapien sit amet tellus fermentum mollis. Nullam massa orci, auctor ac congue id, tincidunt quis lacus. In sed lectus id lacus tincidunt feugiat. Curabitur sed est mi. Nullam a orci eget sapien condimentum semper ut sit amet dolor. Nunc vel odio pharetra, accumsan sem ut, pretium nisi. Phasellus urna tortor, luctus et hendrerit nec, maximus et sapien. Pellentesque pulvinar, dui vel vehicula dignissim, ligula felis pharetra ex, varius viverra purus nulla quis quam."
    Public Const Comment_Paragraphs As String = "Vivamus porttitor nulla quis neque accumsan, vel viverra nunc sagittis. Aenean mauris metus, placerat sit amet dapibus vel, mollis a ante. Vivamus vel mi ut mauris ultricies mollis quis et sapien. Etiam scelerisque justo libero, ut posuere lectus tristique a. Donec venenatis rhoncus ante vel egestas. Quisque rutrum quis diam et hendrerit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Cras rutrum erat in ipsum pharetra, at facilisis tortor gravida. Maecenas non neque luctus, porta ante vel, posuere orci. Nunc finibus diam eget urna posuere, ac tempus orci eleifend. Cras turpis sapien, tempus a risus sed, ultricies ultricies orci. Curabitur accumsan egestas augue id sodales. Fusce interdum tempus sem, nec fringilla lectus sodales quis. Morbi a leo placerat, dignissim mauris nec, rutrum lectus. Vivamus vitae fermentum libero." _
                                                 + vbCrLf + _
                                                 "Integer in interdum lorem, vitae facilisis elit. Vestibulum quis ipsum eu est rutrum placerat in a metus. Curabitur pretium tortor mauris, vitae finibus erat pellentesque in. In semper augue massa, sit amet elementum sem venenatis vel. Aliquam feugiat varius ex, id molestie nisl pulvinar et. Suspendisse eu molestie felis, at scelerisque est. Morbi tincidunt eu lacus at feugiat."
    Public Const Comment_AttackEmbededJS As String = "This is some text before the attack.< s c r i p t >alert('XSS');</ s c r i p t >This is text after the attack"
    Public Const Comment_AttackEmbededIMG As String = "This is some text before the attack.<img src=http%3A%2F%2Fwww." + SafeBadGuySite_URL + "%2FAttackCat.png />"




    '"<html><head></head><body><img src=\"\" onerror=\"XSS\" /></body></html>";
    '"<img src=\"\" onerror=\"XSS\" />";
    '"<div style=\"font-family:Foo,Bar\\,'a\\a';font-family:';color:expression(alert(1));y'\">aaa</div>";
    '"<html><head><meta http-equiv=\"refresh\" content=\"0;url=javascript:alert('XSS');\"></head><body></body></html>";
    '"<html><head></head><body><table background=\"javascript:alert('XSS');\"></table></body></html>";
    '"<html><head></head><body><object classid=clsid:ae24fdae-03c6-11d1-8b76-0080c744f389><param name=url value=javascript:alert('XSS')></object></body></html>";
    '"<html><head></head><body><embed src=\"\" AllowScriptAccess=\"always\"></embed></body></html>";
    '"<html><head></head><body><xml id=\"xss\"></xml></body></html>";


    '' add emojo tests


    Public Const DefaultValue As String = "DefaultValue"
    Public Const ExceptionMessage_NotAnUnsafeValidatorException As String = "Given type doesn't inherit from UnsafeValidator."

End Class
