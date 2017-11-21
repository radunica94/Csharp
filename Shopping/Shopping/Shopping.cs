using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    class Shopping
    {
        private Product[] productList;

        public struct Product
        {
            public int price;
            public int numberOfProducts;
            public Product(int price, int numberOfProducts)
            {
                this.price = price;
                this.numberOfProducts = numberOfProducts;
            }
        }
        public Shopping(Product[] productList)
        {
            this.productList = productList;
        }

        public int TotalPrice()
        {
            int totalPrice = 0;
            for(int i=0; i< productList.Length; i++)
            {
                totalPrice += productList[i].numberOfProducts * productList[i].price;
            }
            return totalPrice;
        }
    }
}
