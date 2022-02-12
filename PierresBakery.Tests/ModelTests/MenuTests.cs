using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class MenuTests
  {
//Bread Tests
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsBreadOrdered_Int()
    {
      //Arrange
      int breadQuantity = 1;
      Bread newBread = new Bread(breadQuantity);
      //Act
      int order = newBread.BreadQuantity;
      //Assert
      Assert.AreEqual(breadQuantity, order);
    }
    [TestMethod]
    public void GetDescription_ReturnsCostOfNoBread_Int()
    {
      //Arrange
      int breadQuantity = 0;
      Bread newBread = new Bread(breadQuantity);
      //Act
      int order = newBread.BreadQuantity;
      //Assert
      Assert.AreEqual(0, order);
    }
    [TestMethod]
    public void GetDescription_ReturnsCostOfOneBread_Int()
    {
      //Arrange
      int breadQuantity = 1;
      Bread newBread = new Bread(breadQuantity);
      //Act
      newBread.SetPrice();
      //Assert
      Assert.AreEqual(5, newBread.SetPrice());
    }
    [TestMethod]
    public void GetDescription_ReturnsCostOfTwoBread_Int()
    {
      //Arrange
      int breadQuantity = 2;
      Bread newBread = new Bread(breadQuantity);
      //Act
      newBread.SetPrice();
      //Assert
      Assert.AreEqual(10, newBread.SetPrice());
    }
    [TestMethod]
    public void GetDescription_ReturnsCostOfThreeBread_Int()
    {
      //Arrange
      int breadQuantity = 3;
      Bread newBread = new Bread(breadQuantity);
      //Act
      newBread.SetPrice();
      //Assert
      Assert.AreEqual(10, newBread.SetPrice());
    }

//Pastry Tests
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsPastryOrdered_Int()
    {
      //Arrange
      int pastryQuantity = 1;
      Pastry newPastry = new Pastry(pastryQuantity);
      //Act
      int order = newPastry.PastryQuantity;
      //Assert
      Assert.AreEqual(pastryQuantity, order);
    }
    [TestMethod]
    public void GetDescription_ReturnsCostOfNoPastry_Int()
    {
      //Arrange
      int pastryQuantity = 0;
      Pastry newPastry = new Pastry(pastryQuantity);
      //Act
      int order = newPastry.PastryQuantity;
      //Assert
      Assert.AreEqual(0, order);
    }
    [TestMethod]
    public void GetDescription_ReturnsCostOfOnePastry_Int()
    {
      //Arrange
      int pastryQuantity = 1;
      Pastry newPastry = new Pastry(pastryQuantity);
      //Act
      int order = newPastry.PastryQuantity;
      //Assert
      Assert.AreEqual(1, order);
    }
    [TestMethod]
    public void GetDescription_ReturnsCostOfTwoPastry_Int()
    {
      //Arrange
      int pastryQuantity = 2;
      Pastry newPastry = new Pastry(pastryQuantity);
      //Act
      int order = newPastry.PastryQuantity;
      //Assert
      Assert.AreEqual(2, order);
    }

  }
}