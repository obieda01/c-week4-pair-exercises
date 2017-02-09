using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class VendMachine
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        private Dictionary<string, VendMachineItems> itemsDictionary;

        public Dictionary<string, VendMachineItems> ItemDictionary
        {
            get { return itemsDictionary; }
            set { itemsDictionary = value; }
        }

        public VendMachine(Dictionary<string, VendMachineItems> vendItems)
        {

            ItemDictionary = vendItems;
        }

    }

}

