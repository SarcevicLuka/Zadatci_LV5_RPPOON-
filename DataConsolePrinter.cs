using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Zadatci_3_i_4
{
    class DataConsolePrinter
    {
        public void PrintData(IDataset dataset)
        {
            IReadOnlyCollection<List<string>> dataInDataset = dataset.GetData();
            if (dataInDataset == null)
            {
                Console.WriteLine("No authorization towards the data.");
            }
            foreach(List<string> oneRowOfData in dataInDataset)
            {
                foreach(string element in oneRowOfData)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
