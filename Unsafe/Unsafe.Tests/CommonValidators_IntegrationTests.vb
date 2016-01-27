Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Unsafe.Data
Imports Unsafe.Data.Common.Validators



<TestClass()> Public Class CommonValidators_IntegrationTests

#Region " CommonValidators_valID_NormalUsage "

    <TestMethod()> Public Sub CommonValidators_valID_NormalUsage()
        Dim tstr As New UnsafeValue(TestValues.Integer_Test)

        Assert.IsTrue(tstr.validate(Of valID).isValid)
        Assert.AreEqual(TestValues.Integer_Test, tstr.validate(Of valID).value)
    End Sub

#End Region
#Region " CommonValidators_valID_MaxValue "

    <TestMethod()> Public Sub CommonValidators_valID_MaxValue()
        Dim tstr As New UnsafeValue(TestValues.Integer_MaxValue)

        Assert.IsTrue(tstr.validate(Of valID).isValid)
        Assert.AreEqual(TestValues.Integer_MaxValue, tstr.validate(Of valID).value)
    End Sub

#End Region
#Region " CommonValidators_valID_MinValue "

    <TestMethod()> Public Sub CommonValidators_valID_MinValue()
        Dim tstr As New UnsafeValue(TestValues.Integer_MinValue)

        Assert.IsFalse(tstr.validate(Of valID).isValid)
        Assert.AreEqual(TestValues.Integer_Zero, tstr.validate(Of valID).value)
    End Sub

#End Region
#Region " CommonValidators_valID_Zero "

    <TestMethod()> Public Sub CommonValidators_valID_Zero()
        Dim tstr As New UnsafeValue(TestValues.Integer_Zero)

        Assert.IsTrue(tstr.validate(Of valID).isValid)
        Assert.AreEqual(TestValues.Integer_Zero, tstr.validate(Of valID).value)
    End Sub

#End Region
#Region " CommonValidators_valID_Neg1 "

    <TestMethod()> Public Sub CommonValidators_valID_Neg1()
        Dim tstr As New UnsafeValue(TestValues.Integer_Neg1)

        Assert.IsFalse(tstr.validate(Of valID).isValid)
        Assert.AreEqual(TestValues.Integer_Zero, tstr.validate(Of valID).value)
    End Sub

#End Region
#Region " CommonValidators_valID_Text "

    <TestMethod()> Public Sub CommonValidators_valID_Text()
        Dim tstr As New UnsafeValue(TestValues.String_SingleWord)

        Assert.IsFalse(tstr.validate(Of valID).isValid)
        Assert.AreEqual(TestValues.Integer_Zero, tstr.validate(Of valID).value)
    End Sub

#End Region
#Region " CommonValidators_valID_IntegerText "

    <TestMethod()> Public Sub CommonValidators_valID_IntegerText()
        Dim tstr As New UnsafeValue(TestValues.String_Integer)

        Assert.IsTrue(tstr.validate(Of valID).isValid)
        Assert.AreEqual(TestValues.Integer_StringTestValue, tstr.validate(Of valID).value)
    End Sub

#End Region
#Region " CommonValidators_valID_Nothing "

    <TestMethod()> Public Sub CommonValidators_valID_Nothing()
        Dim tstr As New UnsafeValue(Nothing)

        Assert.IsFalse(tstr.validate(Of valID).isValid)
        Assert.AreEqual(TestValues.Integer_Zero, tstr.validate(Of valID).value)
    End Sub

#End Region
#Region " CommonValidators_valID_Decimal "

    <TestMethod()> Public Sub CommonValidators_valID_Decimal()
        Dim tstr As New UnsafeValue(TestValues.Decimal_TestValue)

        Assert.IsFalse(tstr.validate(Of valID).isValid)
        Assert.AreEqual(TestValues.Integer_Zero, tstr.validate(Of valID).value)
    End Sub

#End Region

#Region " CommonValidators_valSingleWord_NormalUsage "

    <TestMethod()> Public Sub CommonValidators_valSingleWord_NormalUsage()
        Dim tstr As New UnsafeValue(TestValues.String_SingleWord)

        Assert.IsTrue(tstr.validate(Of valSingleWord).isValid)
        Assert.AreEqual(TestValues.String_SingleWord, tstr.validate(Of valSingleWord).value)
    End Sub

#End Region
#Region " CommonValidators_valSingleWord_ValueTooLong "

    <TestMethod()> Public Sub CommonValidators_valSingleWord_ValueTooLong()
        Dim tstr As New UnsafeValue(TestValues.String_MultiWordNoSpace)

        Assert.IsFalse(tstr.validate(Of valSingleWord).isValid)
        Assert.AreEqual(String.Empty, tstr.validate(Of valSingleWord).value)
    End Sub

#End Region
#Region " CommonValidators_valSingleWord_ValueNothing "

    <TestMethod()> Public Sub CommonValidators_valSingleWord_ValueNothing()
        Dim tstr As New UnsafeValue(Nothing)

        Assert.IsFalse(tstr.validate(Of valSingleWord).isValid)
        Assert.AreEqual(String.Empty, tstr.validate(Of valSingleWord).value)
    End Sub

#End Region
#Region " CommonValidators_valSingleWord_ValueEmptyString "

    <TestMethod()> Public Sub CommonValidators_valSingleWord_ValueEmptyString()
        Dim tstr As New UnsafeValue(String.Empty)

        Assert.IsFalse(tstr.validate(Of valSingleWord).isValid)
        Assert.AreEqual(String.Empty, tstr.validate(Of valSingleWord).value)
    End Sub

#End Region
#Region " CommonValidators_valSingleWord_ValueContainsSpaces "

    <TestMethod()> Public Sub CommonValidators_valSingleWord_ValueContainsSpaces()
        Dim tstr As New UnsafeValue(TestValues.String_MultiWord)

        Assert.IsFalse(tstr.validate(Of valSingleWord).isValid)
        Assert.AreEqual(String.Empty, tstr.validate(Of valSingleWord).value)
    End Sub

#End Region
#Region " CommonValidators_valSingleWord_ValueContainsNumbers "

    <TestMethod()> Public Sub CommonValidators_valSingleWord_ValueContainsNumbers()
        Dim tstr As New UnsafeValue(TestValues.String_WordAndNumber)

        Assert.IsFalse(tstr.validate(Of valSingleWord).isValid)
        Assert.AreEqual(String.Empty, tstr.validate(Of valSingleWord).value)
    End Sub

#End Region
#Region " CommonValidators_valSingleWord_ValueContainsAttack "

    <TestMethod()> Public Sub CommonValidators_valSingleWord_ValueContainsAttack()
        Dim tstr As New UnsafeValue(TestValues.Attack_ScriptTagOpen)

        Assert.IsFalse(tstr.validate(Of valSingleWord).isValid)
        Assert.AreEqual(String.Empty, tstr.validate(Of valSingleWord).value)
    End Sub

#End Region

#Region " CommonValidators_valSimpleComment_NormalUsage "

    <TestMethod()> Public Sub CommonValidators_valSimpleComment_NormalUsage()
        Dim tstr As New UnsafeValue(TestValues.String_SingleWord)

        Assert.IsTrue(tstr.validate(Of valSimpleComment).isValid)
        Assert.AreEqual(TestValues.String_SingleWord, tstr.validate(Of valSingleWord).value)
    End Sub

#End Region
#Region " CommonValidators_valSimpleComment_ValueTooLong "

    <TestMethod()> Public Sub CommonValidators_valSimpleComment_ValueTooLong()
        Dim tstr As New UnsafeValue(TestValues.String_MultiWordNoSpace)

        Assert.IsFalse(tstr.validate(Of valSimpleComment).isValid)
        Assert.AreEqual(String.Empty, tstr.validate(Of valSimpleComment).value)
    End Sub

#End Region
#Region " CommonValidators_valSimpleComment_ValueNothing "

    <TestMethod()> Public Sub CommonValidators_valSimpleComment_ValueNothing()
        Dim tstr As New UnsafeValue(Nothing)

        Assert.IsFalse(tstr.validate(Of valSimpleComment).isValid)
        Assert.AreEqual(String.Empty, tstr.validate(Of valSingleWord).value)
    End Sub

#End Region
#Region " CommonValidators_valSimpleComment_ValueEmptyString "

    <TestMethod()> Public Sub CommonValidators_valSimpleComment_ValueEmptyString()
        Dim tstr As New UnsafeValue(String.Empty)

        Assert.IsFalse(tstr.validate(Of valSimpleComment).isValid)
        Assert.AreEqual(String.Empty, tstr.validate(Of valSingleWord).value)
    End Sub

#End Region

End Class
