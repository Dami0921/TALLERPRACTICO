using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLERPRACTICO
{
    public class CInvoice : IPay
    { 
        public List<CPRODUCTS> _products = new List<CPRODUCTS>();

        public void AddProducts(CPRODUCTS products)
        {
            _products.Add(products);
        }

        public double ValueToPay()
        {
            double TotalValue = 0;

            foreach (CPRODUCTS prod in _products)
            {
                TotalValue += prod.ValueToPay();
            }
            return TotalValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
