using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Zadatci_3_i_4
{
    class Program_za_zadatak_3
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            DataConsolePrinter consolePrinter = new DataConsolePrinter();

            Dataset dataset = new Dataset("D: \\Users\\Korisnik\\Desktop\\LV5 csv datoteka.txt");
            Console.WriteLine("Printing data from dataset class:");
            consolePrinter.PrintData(dataset);
            Console.WriteLine();

            VirtualProxyDataset virtualProxy = new VirtualProxyDataset("D: \\Users\\Korisnik\\Desktop\\LV5 csv datoteka.txt");
            Console.WriteLine("Printing data from VirtualProxyDataset class:");
            consolePrinter.PrintData(virtualProxy);
            Console.WriteLine();

            User user = User.GenerateUser("Luka");
            ProtectionProxyDataset protectionProxyDataset = new ProtectionProxyDataset(user);
            Console.WriteLine("Printing data from ProtectionProxyDataset class:");
            consolePrinter.PrintData(protectionProxyDataset);
            Console.WriteLine();
        }
    }
}
