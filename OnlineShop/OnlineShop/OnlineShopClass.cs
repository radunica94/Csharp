using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    class OnlineShopClass
    {
        private Product[] productList;
        public struct Product
        {
            public int productId;
            public string productName;
            public decimal productPrice;
            public int numberOfProducts;
            public string description;
            public Product(int productId, string productName, decimal productPrice, int numberOfProducts, string description)
            {
                this.productId = productId;
                this.productName = productName;
                this.productPrice = productPrice;
                this.numberOfProducts = numberOfProducts;
                this.description = description;
            }
        }
        public OnlineShopClass(Product[] productList)
        {
            this.productList = productList;
        }

        public bool Contains(Product product)
        {
            for (int i = 0; i < productList.Length; i++)
                if (productList[i].Equals(product))
                    return true;
            return false;
        }

        public void SearchForProduct()
        {
            string searchedProduct = productList[0].productName;
            int counter = 0;
            for(int i = 0; i < productList.Length; i++)
            {
                if (productList[i].productName == searchedProduct)
                {
                    searchedProduct = productList[i].productName;
                    counter = i;
                }
            }
        }
    }
}
