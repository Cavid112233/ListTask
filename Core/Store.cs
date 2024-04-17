using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Store
    {
        List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public List<Product> RemoveProductsByNo(int no)
        {
            List<Product > NewproductsAfterRemove = new List<Product>();
            foreach (Product product in products)
            {
                if(product.No == no)
                {
                    products.Remove(product);
                }
            }
            return NewproductsAfterRemove;
        }
        public List<Product> GetProducts(int? no)
        {
            foreach (Product product in products)
            {
                if(product.No == no)
                {
                    return products;
                }
            }
            return products;
        }
        public List<Product> FilterProductsByType(Type type)
        {
            foreach (Product product in products)
            {
                if(product.Type == type)
                {
                    return products;
                }
            }
            return products;
        }
        public List<Product> FilterProductsByName(string name)
        {
            foreach (Product product in products)
            {
                if (product.Name == name)
                {
                    return products;
                }
            }
            return products;
        }
    }
}
