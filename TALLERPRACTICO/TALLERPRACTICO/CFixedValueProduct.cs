using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLERPRACTICO
{
    public class CFixedValueProduct : CPRODUCTS
    {
        public override double ValueToPay()
        {
            return Price * Tax;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                 $"\n\tvalue to pay.............: {$"{ValueToPay():C2}",18}";
        }
    }
}
