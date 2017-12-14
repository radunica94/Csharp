using System;
using Xunit;

namespace Shopping
{
    public class ShoppingCartTest
    {
        [Fact]
        public void TestTheStruct()
        {
            Shopping.Product result = new Shopping.Product(10, 2);
            var price = result.price;
            Assert.Equal(10, price);
        }
        [Fact]
        public void CalculateTotalPrice()
        {
            Shopping.Product[] result = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(15, 2), new Shopping.Product(2, 1) };
            Shopping shoppingList = new Shopping(result);
            var newList = shoppingList.TotalPrice();
            Assert.Equal(37, newList);
        }
        [Fact]
        public void GetTheCheapestProduct()
        {
            Shopping.Product[] result = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(15, 1), new Shopping.Product(2, 1) };
            Shopping shoppingList = new Shopping(result);
            var newList = shoppingList.CheapestProduct();
            Assert.Equal(result[2], newList);
        }
        [Fact]
        public void RemoveTheMostExpensiveProduct()
        {
            Shopping.Product[] result = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(15, 1), new Shopping.Product(2, 1) };
            Shopping.Product[] newResult = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(2, 1) };
            Shopping shoppingList = new Shopping(result);
            var newList = shoppingList.RemoveTheMostExpensiveProduct();
            Assert.Equal(newResult, newList);
        }
        [Fact]
        public void AddNewProduct()
        {
            Shopping.Product[] result = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(15, 1), new Shopping.Product(2, 1) };
            Shopping.Product[] newResult = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(15, 1), new Shopping.Product(2, 1), new Shopping.Product(2, 2) };
            Shopping shoppingList = new Shopping(result);
            var newList = shoppingList.AddNewProduct(new Shopping.Product(2, 2));
            Assert.Equal(newResult, newList);
        }
        [Fact]
        public void CalculateMediumPrice()
        {
            Shopping.Product[] result = new Shopping.Product[] { new Shopping.Product(5, 1), new Shopping.Product(15, 1), new Shopping.Product(4, 1) };
            Shopping shoppingList = new Shopping(result);
            var newList = shoppingList.MediumPrice();
            Assert.Equal(8, newList);
        }
    }
}
