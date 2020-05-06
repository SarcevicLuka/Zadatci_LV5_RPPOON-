using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class Program_za_1_i_2_zadatak
    {
        static void Main(string[] args)
        {
            Product shoes = new Product("Wite Nikes for men", 600, 0.5);
            Product monitor = new Product("LG monitor, 17 inches", 1500, 2);
            Console.WriteLine(shoes.Description());
            Console.WriteLine(monitor.Description());

            Box boxOfProducts = new Box("Box of products for shipping");
            boxOfProducts.Add(shoes);
            boxOfProducts.Add(monitor);
            Console.WriteLine(boxOfProducts.Description());

            ShippingService shippingService = new ShippingService(3.76);
            Console.WriteLine("Price of deliveri for shoes is: " + shippingService.DeliveringFee(shoes.Weight));
            Console.WriteLine("Price of deliveri for monitor is: " + shippingService.DeliveringFee(monitor.Weight));
            Console.WriteLine("Price of deliveri for box is: " + shippingService.DeliveringFee(boxOfProducts.Weight));
        }
    }
}
