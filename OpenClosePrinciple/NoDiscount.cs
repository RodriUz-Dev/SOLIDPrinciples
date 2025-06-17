using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClosePrinciple
{
    public class NoDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal price) => price;
    }    
}
