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
            for (int i = 0; i < productList.Length; i++)
            {
                totalPrice += productList[i].numberOfProducts * productList[i].price;
            }
            return totalPrice;
        }

        public Product CheapestProduct()
        {
            int cheapestProduct = productList[0].price;
            int counter = 0;
            for (int i = 0; i < productList.Length; i++)
            {
                if (productList[i].price < cheapestProduct)
                {
                    cheapestProduct = productList[i].price;
                    counter = i;
                }
            }
            return productList[counter];
        }

        public Product[] MostExpensiveProduct()
        {
            int mostExpensiveProduct = productList[0].price;
            int counter = 0;
            for(int i = 0; i < productList.Length; i++)
            {
                if (productList[i].price > mostExpensiveProduct)
                {
                    mostExpensiveProduct = productList[i].price;
                    counter = i;
                }
            }
            for (int i = counter; i < productList.Length - 1; i++)
                productList[i] = productList[i + 1];
            Array.Resize(ref productList, productList.Length - 1);
            return productList;
        }

        public Product[] AddNewProduct(Product[] productList,Product newProduct)
        {
            Product[] newProductList = new Product[productList.Length + 1];
            newProductList = productList;
            newProductList[newProductList.Length - 1] = newProduct;
            return newProductList;
        }
        public int MediumPrice()
        {
            int total = 0;
            for(int i = 0; i < productList.Length; i++)
            {
                total += productList[i].price;
            }
            return total / productList.Length;
        }
    }
}


