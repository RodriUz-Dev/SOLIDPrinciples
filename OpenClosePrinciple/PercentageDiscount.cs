using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClosePrinciple
{
    public class PercentageDiscount: IDiscount
    {
        private readonly decimal _percentage;
        public PercentageDiscount(decimal percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentOutOfRangeException(nameof(percentage), "Percentage must be between 0 and 100.");
            _percentage = percentage;
        }
        public decimal ApplyDiscount(decimal price) => price - CalculateDiscount(price);

        private decimal CalculateDiscount(decimal price) => price * (_percentage / 100);
       
    }
}
