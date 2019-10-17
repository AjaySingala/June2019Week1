using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace MyUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_CreateCustomerReturnsWithId()
        {
            // Arrange.
            Customer cust = new Customer()
            {
                Name = "ABC",
                City = "Dallas"
            };

            CustomerBL bl = new CustomerBL();

            int expected = 1;

            // Act.
            bl.Create(cust);

            // Assert.
            Assert.AreEqual(expected, cust.Id);

        }
    }
}
