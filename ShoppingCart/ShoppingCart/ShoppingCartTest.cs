using System;
using Xunit;

namespace Shopping
{
    public class ShoppingCartTest
    {
        [Fact]
        public void TestTheStruct()
        {
            ShoppingCart.Product result = new ShoppingCart.Product("A", 10, 2);
            var price = result.price;
            Assert.Equal(10, price);
        }
        [Fact]
        public void CalculateTotalPrice()
        {
            ShoppingCart.Product[] result = new ShoppingCart.Product[] {
                new ShoppingCart.Product("A", 5, 1),
                new ShoppingCart.Product("B", 15, 2),
                new ShoppingCart.Product("C", 2, 1) };
            ShoppingCart shoppingList = new ShoppingCart(result);
            var newList = shoppingList.TotalPrice();
            Assert.Equal(37, newList);
        }
        [Fact]
        public void GetTheCheapestProduct()
        {
            ShoppingCart.Product[] result = new ShoppingCart.Product[] {
                new ShoppingCart.Product("A", 5, 1),
                new ShoppingCart.Product("B", 15, 1),
                new ShoppingCart.Product("C", 2, 1) };
            ShoppingCart shoppingList = new ShoppingCart(result);
            var newList = shoppingList.CheapestProduct();
            Assert.Equal(result[2], newList);
        }
        [Fact]
        public void RemoveTheMostExpensiveProduct()
        {
            var mostExpensive = new ShoppingCart.Product("E", 15, 1);
            var result = new ShoppingCart.Product[] {
                new ShoppingCart.Product("A", 5, 1),
                mostExpensive,
                new ShoppingCart.Product("B", 2, 1) };
            var shoppingList = new ShoppingCart(result);
            shoppingList.RemoveTheMostExpensiveProduct();
            Assert.False(shoppingList.Contains(mostExpensive));
        }
        [Fact]
        public void AddNewProduct()
        {
            var addedProduct = new ShoppingCart.Product("E", 2, 1);
            var result = new ShoppingCart.Product[] {
                new ShoppingCart.Product("A", 5, 1),
                new ShoppingCart.Product("B", 15, 1),
                new ShoppingCart.Product("C", 2, 1)} ;            
            var shoppingList = new ShoppingCart(result);
            shoppingList.AddNewProduct(addedProduct);
            Assert.True(shoppingList.Contains(addedProduct));
        }
        [Fact]
        public void CalculateMediumPrice()
        {
            ShoppingCart.Product[] result = new ShoppingCart.Product[] {
                new ShoppingCart.Product("A", 5, 1),
                new ShoppingCart.Product("B", 15, 1),
                new ShoppingCart.Product("C", 4, 1) };
            ShoppingCart shoppingList = new ShoppingCart(result);
            var newList = shoppingList.MediumPrice();
            Assert.Equal(8, newList);
        }
    }
}
