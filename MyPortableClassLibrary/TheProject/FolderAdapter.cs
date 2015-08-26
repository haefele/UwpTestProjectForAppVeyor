using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml;

namespace TheProject
{
    public class FolderAdapter
    {
        public FolderAdapter(StorageFolder folder)
        {
            
        }

        public void DoThing()
        {
            int id = 2;
            string s = $"the id is {id}";
        }
    }
}
