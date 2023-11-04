using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            List<Product> products = new List<Product>();
            for (int i = 0; i < cart.GetProductsCount(); i++) {
                products.Add(cart.GetProductByIndex(i));
            }

            products.RemoveAt(0);

            cart.ShowProduct();
            Console.ReadKey();
        }
    }

    class Cart
    {
        private List<Product> products = new List<Product>();

        public Cart() {
            products.Add(new Product("Яблоко"));
            products.Add(new Product("Банан"));
            products.Add(new Product("Апельсин"));
            products.Add(new Product("Груша"));
        }

        public void ShowProduct()
        {
            foreach (var product in products)
                Console.WriteLine(product.Name);
        }

        public Product GetProductByIndex(int index)
        {
            return products[index];
        }

        public int GetProductsCount()
        {
            return products.Count;
        }
    }

    class Product 
    { 
        public string Name { get; private set; }

        public Product(string name) { 
            Name = name;
        }
    }
}
