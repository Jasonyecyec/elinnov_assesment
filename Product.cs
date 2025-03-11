using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elinnov_exam
{
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int QuantityInStock { get; set; }
        public double Price { get; set; }

        public Product(int ProductId, string Name, int QuantityInStock, double Price)
        {
            this.ProductId = ProductId;
            this.Name = Name;
            this.QuantityInStock = QuantityInStock;
            this.Price = Price;
        }
    }
}
