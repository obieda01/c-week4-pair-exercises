using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class VendMachine
    {
        private int itemCount = 5;

        public int ItemCount
        {
            get { return itemCount; }
          
        }

        private Dictionary<string,string> itemsDictionary;

        public Dictionary<string,string> ItemDictionary
        {
            get { return itemsDictionary; }
        }

        public VendMachine(VendMachineItems vendItems)
        {
           itemsDictionary = vendItems.; }

        }

    }

}

