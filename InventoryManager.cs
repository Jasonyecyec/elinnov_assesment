using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elinnov_exam
{
    class InventoryManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct (Product product)
        {
            products.Add(product);
            Console.WriteLine("Product added successfully!");
        }

        public void RemoveProduct(int productId)
        {
            var product = products.Find(item => item.ProductId == productId);

            if(product != null)
            {
                products.Remove(product);
            }
            else
            {
                Console.WriteLine($"Product ID {productId} not found");
            }
        }

        public void ListProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("--- No products in inventory --- ");
                return;
            }

            Console.WriteLine("\n Product List: ");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ProductId} | Name: {product.Name} | Quantity: {product.QuantityInStock} | Price: {product.Price}");
            }
        }

        public void UpdateProduct(int productId, int newQuantity)
        {
            var product = products.Find(item => item.ProductId == productId);
            if (product != null)
            {
                product.QuantityInStock = newQuantity;
                Console.WriteLine("Product Updated");
            }
            else
            {
                Console.WriteLine("Product Not Found.");
            }
        }

        public double GetTotalValue()
        {
            double total = 0;

            foreach (var product in products)
            {
                total += product.QuantityInStock * product.Price;
            }

            return total;
        }
    }
}
