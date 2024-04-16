using Lab2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class ArithmeticsTests
{
    [TestMethod]
    public void Add_ReturnsCorrectResult()
    {
        Arithmetics arithmetics = new Arithmetics();
        Assert.AreEqual(5, arithmetics.Add(2, 3));
    }

    [TestMethod]
    public void Subtract_ReturnsCorrectResult()
    {
        Arithmetics arithmetics = new Arithmetics();
        Assert.AreEqual(2, arithmetics.Subtract(5, 3));
    }

    [TestMethod]
    public void Multiply_ReturnsCorrectResult()
    {
        Arithmetics arithmetics = new Arithmetics();
        Assert.AreEqual(15, arithmetics.Multiply(5, 3));
    }

    [TestMethod]
    public void Divide_ReturnsCorrectResult()
    {
        Arithmetics arithmetics = new Arithmetics();
        Assert.AreEqual(2, arithmetics.Divide(6, 3));
    }

    [TestMethod]
    public void Divide_ByZero_ThrowsException()
    {
        Arithmetics arithmetics = new Arithmetics();
        Assert.ThrowsException<ArgumentException>(() => arithmetics.Divide(6, 0));
    }

    [TestMethod]
    public void Add_NegativeNumbers_ReturnsCorrectResult()
    {
        Arithmetics arithmetics = new Arithmetics();
        Assert.AreEqual(-1, arithmetics.Add(-2, 1));
    }

    [TestMethod]
    public void Subtract_NegativeNumbers_ReturnsCorrectResult()
    {
        Arithmetics arithmetics = new Arithmetics();
        Assert.AreEqual(-4, arithmetics.Subtract(-1, 3));
    }

    [TestMethod]
    public void Multiply_NegativeNumbers_ReturnsCorrectResult()
    {
        Arithmetics arithmetics = new Arithmetics();
        Assert.AreEqual(-6, arithmetics.Multiply(-2, 3));
    }

    [TestMethod]
    public void Divide_NegativeNumbers_ReturnsCorrectResult()
    {
        Arithmetics arithmetics = new Arithmetics();
        Assert.AreEqual(-2, arithmetics.Divide(6, -3));
    }

    [TestMethod]
    public void Divide_DecimalNumbers_ReturnsCorrectResult()
    {
        Arithmetics arithmetics = new Arithmetics();
        Assert.AreEqual(2.5, arithmetics.Divide(5, 2));
    }
}