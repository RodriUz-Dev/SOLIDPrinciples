using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibilityPrinciple
{
    public class ProductRepository
    {
        private readonly List<Product> _products = new();

        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            _products.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }
        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

    }
}
