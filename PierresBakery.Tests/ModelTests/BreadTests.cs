using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_ShouldCreateAnInstanceOfBread_Bread()
    {
      Bread breadOrder = new Bread(3);
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }

    [TestMethod]
    public void GetBreadCount_ReturnsBreadCount_Int()
    {
      int breadCount = 3;
      Bread breadOrder = new Bread(3);
      int result = breadOrder.Quantity;
      Assert.AreEqual(breadCount, result);
    }

    [TestMethod]
    public void CalculateTotal_Returns5IfOrdering1Bread_Int()
    {
      Bread breadOrder = new Bread(1);
      int breadTotal = breadOrder.CalculateTotal();
      Assert.AreEqual(5, breadTotal);
    }

    [TestMethod]
    public void CalculateTotal_Returns10IfOrdering2Breads_Int()
    {
      Bread breadOrder = new Bread(2);
      int breadTotal = breadOrder.CalculateTotal();
      Assert.AreEqual(10, breadTotal);
    }

    [TestMethod]
    public void CalculateTotal_Returns10IfOrdering3Breads_Int()
    {
      Bread breadOrder = new Bread(3);
      int breadTotal = breadOrder.CalculateTotal();
      Assert.AreEqual(10, breadTotal);
    }

    [TestMethod]
    public void CalculateTotal_Returns20IfOrdering6Breads_Int()
    {
      Bread breadOrder = new Bread(6);
      int breadTotal = breadOrder.CalculateTotal();
      Assert.AreEqual(20, breadTotal);
    }
  }
}
