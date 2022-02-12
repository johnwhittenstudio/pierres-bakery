using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class MenuTests
  {
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

  }
}