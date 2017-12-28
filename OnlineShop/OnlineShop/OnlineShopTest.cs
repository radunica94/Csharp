using System;
using Xunit;

namespace OnlineShop
{
    public class OnlineShopTest
    {
        [Fact]
        public void TestTheStruct()
        {
            OnlineShopClass.Product result = new OnlineShopClass.Product(1,"Samsung A5", 100, 3, "Model 2017");
            var productPrice = result.productPrice;
            Assert.Equal(100, productPrice);
        }
        [Fact]
        public void SearchForProduct()
        {
            var searchedProduct = new OnlineShopClass.Product(2,"Samsung Galaxy A5", 100, 3, "Model 2017");
            var result = new OnlineShopClass.Product[] {
                new OnlineShopClass.Product(1,"Iphone X", 100, 3, "Model 2017"),
                searchedProduct,
                new OnlineShopClass.Product(3,"Samsung Galaxy S8", 100, 3, "Model 2017") };
            var listOfProducts = new OnlineShopClass(result);
            listOfProducts.SearchForProduct();
            Assert.True(listOfProducts.Contains(searchedProduct));
        }
    }
}
