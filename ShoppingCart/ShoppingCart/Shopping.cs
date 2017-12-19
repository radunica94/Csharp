using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    class ShoppingCart
    {
        private Product[] productList;
        public struct Product
        {
            public string name;
            public int price;
            public int numberOfProducts;
            public Product(string name, int price, int numberOfProducts)
            {
                this.name = name;
                this.price = price;
                this.numberOfProducts = numberOfProducts;
            }
            public override bool Equals(object obj)
            {
                var otherProduct = (Product)obj;
                return this.name.Equals(otherProduct.name, StringComparison.CurrentCultureIgnoreCase);
            }
        }
        public ShoppingCart(Product[] productList)
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

        public void RemoveTheMostExpensiveProduct()
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
        }

        public void AddNewProduct(Product newProduct)
        {
            Array.Resize(ref productList, productList.Length + 1);
            productList[productList.Length - 1] = newProduct;            
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
        public bool Contains(Product product)
        {
            for (int i = 0; i < productList.Length; i++)
                if (productList[i].Equals(product))
                    return true;
            return false;
        }
    }
}


