using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClosePrinciple
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal price);
    }
}
