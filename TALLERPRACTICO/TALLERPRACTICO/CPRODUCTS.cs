using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TALLERPRACTICO
{
    public abstract class CPRODUCTS
    {
        public string Description { get; set; }

        public int ID { get; set; }

        public double Price { get; set; }

        public float Tax { get; set; }

        public abstract double ValueToPay();

        public override string ToString()
        {
            return $"Description product: {Description}, ID product: {ID}" +
                $"\n\tPrice: {Price:N2}, Tax: {Tax}";
        }
    }
}
