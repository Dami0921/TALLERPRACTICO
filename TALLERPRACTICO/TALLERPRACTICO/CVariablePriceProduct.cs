using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLERPRACTICO
{
    public class CVariablePriceProduct : CPRODUCTS
    {
        public string Measurement { get; set; }

        public  float Quantity { get; set; }

        public override double ValueToPay()
        {
            return Price * Quantity * Tax;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tMeasurement..............: {$"{Measurement}",18}"+
                $"\n\tQuantity.................: {$"{Quantity:C2}",18}"+
                $"\n\tvalue to pay.............: {$"{ValueToPay():C2}",18}";
        }
    }
}
