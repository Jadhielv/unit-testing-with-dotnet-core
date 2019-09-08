using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSystem;

namespace app_test
{
    [TestClass]
    public class OrderHelperTest
    {
        [TestMethod]
        public void ShouldSumCostOfOrder()
        {
            // Arrange  
            var ProductCD = new Product()
            {
                Type = ProductType.CD,
                Name = "Nirvana",
                Description = "Album"
            };
            var ProductMovie = new Product()
            {
                Type = ProductType.DVD,
                Name = "Gladiator",
                Description = "Movie"
            };

            var order = new Order()
            {
                Items = new List<OrderItem>(){
                    new OrderItem(){
                        Quantity = 1,
                        Price = 10,
                        Product = ProductCD
                    },
                    new OrderItem(){
                        Quantity = 2,
                        Price = 10,
                        Product = ProductMovie
                    }
                }
            };

            // Act
            var actual = OrderHelper.Cost(order);

            // Assert
            Assert.AreEqual(30, actual);
        }
    }
}