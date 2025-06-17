using SOLIDPrinciples.OpenClosePrinciple;
using SOLIDPrinciples.SingleResponsibilityPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovSubstitutionPrinciple
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly IDiscount _discount;
        public ProductService(ProductRepository productRepository, IDiscount discount)
        {
            _productRepository = productRepository;
            _discount = discount;
        }

        public decimal GetDiscountedPrice(Product product)
        {
            return _discount.ApplyDiscount(product.Price);
        }

    }
}
