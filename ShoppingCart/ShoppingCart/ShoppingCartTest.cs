using System;
using Xunit;

namespace Shopping
{
    public class ShoppingCartTest
    {
        [Fact]
        public void Test1()
        {
            Shopping.Product result = new Shopping.Product(10, 2);
            var price = result.price;
            Assert.Equal(10, price);
        }
        [Fact]
        public void TotalPrice()
        {
            Shopping.Product[] result = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(15, 2), new Shopping.Product(2, 1) };
            Shopping productList = new Shopping(result);
            var method = productList.TotalPrice();
            Assert.Equal(37, method);
        }
        [Fact]
        public void CheapestProduct()
        {
            Shopping.Product[] result = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(15, 1), new Shopping.Product(2, 1) };
            Shopping productList = new Shopping(result);
            var method = productList.CheapestProduct();
            Assert.Equal(result[2], method);
        }
        [Fact]
        public void MostExpensiveProduct()
        {
            Shopping.Product[] result = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(15, 1), new Shopping.Product(2, 1) };
            Shopping.Product[] newResult = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(2, 1) };
            Shopping productList = new Shopping(result);
            var method = productList.MostExpensiveProduct();
            Assert.Equal(newResult, method);
        }
        [Fact]
        public void AddNewProduct()
        {
            Shopping.Product[] result = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(15, 1), new Shopping.Product(2, 1) };
            Shopping.Product[] newResult = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(15, 1), new Shopping.Product(2, 1), new Shopping.Product(2, 2) };
            Shopping productList = new Shopping(result);
            var method = productList.AddNewProduct(newResult, new Shopping.Product(2, 2));
            Assert.Equal(newResult, method);
        }
    }
}
