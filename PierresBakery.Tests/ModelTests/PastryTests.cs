using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_ShouldCreateAnInstanceOfPastry_Pastry()
    {
      Pastry pastryOrder = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
    }

    [TestMethod]
    public void GetPastryCount_ReturnsPastryCount_Int()
    {
      int pastryCount = 3;
      Pastry pastryOrder = new Pastry(3);
      int result = pastryOrder.Quantity;
      Assert.AreEqual(pastryCount, result);
    }

    [TestMethod]
    public void CalculateTotal_Returns2IfOrdering1Pastry_Int()
    {
      Pastry pastryOrder = new Pastry(1);
      int pastryTotal = pastryOrder.CalculateTotal();
      Assert.AreEqual(2, pastryTotal);
    }

    [TestMethod]
    public void CalculateTotal_Returns6IfOrdering3Pastries_Int()
    {
      Pastry pastryOrder = new Pastry(3);
      int pastryTotal = pastryOrder.CalculateTotal();
      Assert.AreEqual(6, pastryTotal);
    }

    [TestMethod]
    public void CalculateTotal_Returns6IfOrdering4Pastries_Int()
    {
      Pastry pastryOrder = new Pastry(4);
      int pastryTotal = pastryOrder.CalculateTotal();
      Assert.AreEqual(6, pastryTotal);
    }

    [TestMethod]
    public void CalculateTotal_Returns12IfOrdering8Pastries_Int()
    {
      Pastry pastryOrder = new Pastry(8);
      int pastryTotal = pastryOrder.CalculateTotal();
      Assert.AreEqual(12, pastryTotal);
    }
  }
}