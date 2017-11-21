using System;
using Xunit;

namespace Shopping
{
    public class ShoppingTest
    {
        [Fact]
        public void producTest()
        {
            Shopping.Product result = new Shopping.Product(10,2);
            var price = result.price;
            Assert.Equal(10,price);
        }
        [Fact]
        public void TotalPrice()
        {
            Shopping.Product[] result = new Shopping.Product[] {new Shopping.Product(5,1) , new Shopping.Product(15,2), new Shopping.Product(2,1) };
            Shopping productList = new Shopping(result);
            var method = productList.TotalPrice();
            Assert.Equal(37, method);
        }
    }
}
