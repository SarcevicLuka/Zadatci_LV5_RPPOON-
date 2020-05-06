using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Zadatci_3_i_4
{
    interface IDataset
    {
        ReadOnlyCollection<List<string>> GetData();
    }
}
