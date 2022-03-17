using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var controller = new CoffeesController();
             var model = new Coffee()

            // Act
            ActionResult<Coffee> result = controller.Create();

            // Assert
            Coffee createdPost = result.Value;
            Assert.NotNull(createdPost);
        }
    }
}
