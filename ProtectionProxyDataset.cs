using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Zadatci_3_i_4
{
    class ProtectionProxyDataset : IDataset
    {
        private Dataset dataset;
        private List<int> allowedIDs;
        public User user { private get; set; }
        public ProtectionProxyDataset(User user)
        {
            this.allowedIDs = new List<int>(new int[] { 1, 3, 5 });
            this.user = user;
        }
        private bool AuthenticateUser()
        {
            return allowedIDs.Contains(this.user.ID);
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (this.AuthenticateUser())
            {
                if (this.dataset == null)
                {
                    this.dataset = new Dataset("D: \\Users\\Korisnik\\Desktop\\LV5 csv datoteka.txt");
                }
                return this.dataset.GetData();
            }
            return null;
        }
    }
}
