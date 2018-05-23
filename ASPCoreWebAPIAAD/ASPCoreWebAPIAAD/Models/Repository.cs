using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreWebAPIAAD.Models
{
    public static class Repository
    {
        private static int counter;
        public static IList<Product> Products { get; } = new List<Product>();

        public static Product GetProductById(int id)
        {
            var output = Products.SingleOrDefault(p => p.Id == id);
            return output;
        }

        public static void RemoveProductById(int id)
        {
            var output = Products.SingleOrDefault(p => p.Id == id);
            if(output != null)
                Products.Remove(output);
        }

        public static void ReplaceProductById(int id, Product product)
        {
            var output = Products.SingleOrDefault(p => p.Id == id);
            if (output != null)
            {
                Products.Remove(output);
                Products.Add(product);
            }                
        }

        public static void AddProduct(Product product)
        {
            product.Id = counter++;
            Products.Add(product);
        }
    }
}
