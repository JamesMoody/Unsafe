Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Unsafe.Data


<TestClass()> Public Class UnsafeValue_IntegrationTests


#Region " UnsafeValue_SimpleStringTest_isValid "

    <TestMethod()> Public Sub UnsafeValue_SimpleStringTest_isValid()
        Dim tstr As New UnsafeValue(TestValues.String_SingleWord)

        Assert.IsTrue(tstr.validate(Of valSimpleTest).isValid)
    End Sub

#End Region
#Region " UnsafeValue_SimpleStringTest_Value "

    <TestMethod()> Public Sub UnsafeValue_SimpleStringTest_Value()
        Dim tstr As New UnsafeValue(TestValues.String_SingleWord)

        Assert.AreEqual(TestValues.String_SingleWord, tstr.validate(Of valSimpleTest).value)
    End Sub

#End Region

#Region " UnsafeValue_DeepInheritanceException "

    <TestMethod()> Public Sub UnsafeValue_DeepInheritance()
        Dim tstr As New UnsafeValue(TestValues.String_SingleWord)

        Assert.IsTrue(tstr.validate(Of valSimpleTest2).isValid)
    End Sub

#End Region
#Region " UnsafeValue_BadValidatorException "

    <TestMethod()> Public Sub UnsafeValue_BadValidatorException()
        Try
            Dim tstr As New UnsafeValue(TestValues.String_SingleWord)
            Dim result As Boolean = tstr.validate(Of Object).isValid

            ' we should never get here
            Assert.Fail("Expected Exception: NotAnUnsafeValidatorException")

        Catch ex As Exception
            Assert.IsTrue(TypeOf ex Is NotAnUnsafeValidatorException)
            Assert.AreEqual(TestValues.ExceptionMessage_NotAnUnsafeValidatorException, ex.Message)

        End Try
    End Sub

#End Region

#Region " UnsafeValue_DefaultTest_IsValid "

    <TestMethod()> Public Sub UnsafeValue_DefaultTest_IsValid()
        Dim tstr As New UnsafeValue(TestValues.String_SingleWord)

        Assert.IsFalse(tstr.validate(Of valDefaultTest).isValid)
    End Sub

#End Region
#Region " UnsafeValue_DefaultTest_Value "

    <TestMethod()> Public Sub UnsafeValue_DefaultTest_Value()
        Dim tstr As New UnsafeValue(TestValues.String_SingleWord)

        Assert.AreEqual(TestValues.DefaultValue, tstr.validate(Of valDefaultTest).value)
    End Sub

#End Region

#Region " UnsafeValue_AlwaysFailString_IsValid "

    <TestMethod()> Public Sub UnsafeValue_AlwaysFailString_IsValid()
        Dim tstr As New UnsafeValue(TestValues.String_SingleWord)

        Assert.IsFalse(tstr.validate(Of valAlwaysFailString).isValid)
    End Sub

#End Region
#Region " UnsafeValue_AlwaysFailString_Value "

    <TestMethod()> Public Sub UnsafeValue_AlwaysFailString_Value()
        Dim tstr As New UnsafeValue(TestValues.String_SingleWord)

        Assert.AreEqual(Nothing, tstr.validate(Of valAlwaysFailString).value)
    End Sub

#End Region

#Region " UnsafeValue_AlwaysFailInteger_IsValid "

    <TestMethod()> Public Sub UnsafeValue_AlwaysFailInteger_IsValid()
        Dim tstr As New UnsafeValue(TestValues.Integer_Test)

        Assert.IsFalse(tstr.validate(Of valAlwaysFailInteger).isValid)
    End Sub

#End Region
#Region " UnsafeValue_AlwaysFailInteger_Value "

    <TestMethod()> Public Sub UnsafeValue_AlwaysFailInteger_Value()
        Dim tstr As New UnsafeValue(TestValues.Integer_Test)

        Assert.AreEqual(0, tstr.validate(Of valAlwaysFailInteger).value)
    End Sub

#End Region

#Region " UnsafeValue_AlwaysPassInteger_BadValueType "

    <TestMethod()> Public Sub UnsafeValue_AlwaysPassInteger_BadValueType()
        Try

            Dim tstr As New UnsafeValue(TestValues.String_SingleWord)
            Dim val As Object = tstr.validate(Of valAlwaysPassInteger).value

            Assert.Fail("Expected Exception: InvalidCastException")

        Catch ex As Exception
            Assert.IsTrue(TypeOf ex Is InvalidCastException)

        End Try

    End Sub

#End Region
#Region " UnsafeValue_AlwaysPassInteger_ConvertableValueType "

    <TestMethod()> Public Sub UnsafeValue_AlwaysPassInteger_ConvertableValueType()
        Dim tstr As New UnsafeValue(TestValues.String_Integer)

        Assert.AreEqual(TestValues.Integer_StringTestValue, tstr.validate(Of valAlwaysPassInteger).value)
    End Sub

#End Region
#Region " UnsafeValue_AlwaysPassString_ConvertableValueType "

    <TestMethod()> Public Sub UnsafeValue_AlwaysPassString_ConvertableValueType()
        Dim tstr As New UnsafeValue(TestValues.Integer_StringTestValue)

        Assert.AreEqual(TestValues.String_Integer, tstr.validate(Of valAlwaysPassString).value)
    End Sub

#End Region

End Class


#Region " helpers classes - valSimpleTest (note: minimum needed to compile... no actual validation) "

Public Class valSimpleTest
    Inherits UnsafeValidator(Of String)

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
#Region " helpers classes - valSimpleTest2 (note: deep inheritance should not fail) "

Public Class valSimpleTest2
    Inherits valSimpleTest

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
#Region " helpers classes - valDefaultTest "

Public Class valDefaultTest
    Inherits UnsafeValidator(Of String)

    Sub New(ByRef value As Object)
        MyBase.New(value, TestValues.DefaultValue)
    End Sub


    Public Overrides ReadOnly Property isValid As Boolean
        Get
            Return False
        End Get
    End Property

End Class

#End Region
#Region " helpers classes - valAlwaysFailString "

Public Class valAlwaysFailString
    Inherits UnsafeValidator(Of String)

    Sub New(ByRef value As Object)
        MyBase.New(value)
    End Sub


    Public Overrides ReadOnly Property isValid As Boolean
        Get
            Return False
        End Get
    End Property

End Class

#End Region
#Region " helpers classes - valAlwaysFailInteger"

Public Class valAlwaysFailInteger
    Inherits UnsafeValidator(Of Integer)

    Sub New(ByRef value As Object)
        MyBase.New(value)
    End Sub


    Public Overrides ReadOnly Property isValid As Boolean
        Get
            Return False
        End Get
    End Property

End Class

#End Region
#Region " helpers classes - valAlwaysPassString "

Public Class valAlwaysPassString
    Inherits UnsafeValidator(Of String)

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
