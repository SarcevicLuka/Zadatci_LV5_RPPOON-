using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class ShippingService
    {
        private double pricePerKg;

        public ShippingService(double pricePerKg)
        {
            this.pricePerKg = pricePerKg;
        }
        public double DeliveringFee(double weight)
        {
            return pricePerKg * weight;
        }
    }
}
