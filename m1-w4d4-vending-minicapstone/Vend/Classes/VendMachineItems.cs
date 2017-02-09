using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class VendMachineItems
    {
        private double itemPrice;

        public double ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        private string itemSlot;

        public string ItemSlot
        {
            get { return itemSlot; }
            set { itemSlot = value; }
        }

        private int itemCount;

        public int ItemCount
        {
            get { return itemCount; }
            set { itemCount = value; }
        }

        Dictionary<string, string> itemDictionary = new Dictionary<string, string>();
        public VendMachineItems(ItemReader itemReader)
        {
            itemDictionary = itemReader.fileReaderCSV();
        }


    }
}
