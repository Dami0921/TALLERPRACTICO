using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLERPRACTICO
{
    public class CComposedProduct : CPRODUCTS
    {
        public List<CPRODUCTS> _products = new List<CPRODUCTS>();

        public void AddProducts(CPRODUCTS product)
        {
            _products.Add(product);
        }
        public float Discount { get; set; }

        public override double ValueToPay()
        {
            double TotalValue = 0;

            foreach (CPRODUCTS prod in _products)
            {
                TotalValue += prod.ValueToPay();
            }
            return TotalValue * Discount;
        }

        public override string ToString()
        {
            return
                $"\n\tDescription..............: {$"{Description}",18}" +
                $"\n\tID.......................: {$"{ID}",18}" +
                $"\n\tDiscount.................: {$"{Discount}",18}" +
                $"\n\tProducts.................: {$"{_products}",18}" +
                $"\n\tvalue to pay.............: {$"{ValueToPay():C2}",18}";
        }
    }
}
