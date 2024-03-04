using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulnev_Clothes_Shop
{
    class Product
    {
        public string name { get; set; }
        public int cost { get; set; }
        public int discount { get; set; }
        public string article { get; set; }
        public int amount { get; set; }
    }
     class Order_cart
    {
        private List<Product> products;
        public Order_cart()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                products.RemoveAt(index);
            }
        }
        public decimal CalculateTotal()//возвращает сумму
        {
            decimal total = 0;

            foreach (var product in products)
            {
                total += product.cost;
            }

            return total;
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
