using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Vend.Classes
{
    public  class ItemReader
    {
        private  Dictionary<string, VendMachineItems> itemDictionary=new Dictionary<string, VendMachineItems>();

        public  Dictionary<string,VendMachineItems> ItemDictionary 
        {
            get { return itemDictionary; }
        }

        public  Dictionary<string, VendMachineItems>  fileReaderCSV()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(Environment.CurrentDirectory, "vendingmachine.csv")))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lineSplitter= sr.ReadLine().Split('|');
                        VendMachineItems item = new VendMachineItems();
                        item.ItemName = lineSplitter[1];
                        item.ItemPrice = double.Parse(lineSplitter[2]);
                        item.ItemCount = 5;
                        item.ItemSlot = lineSplitter[0];
                        ItemDictionary.Add(lineSplitter[0], item);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("can not find file"+e.Message);
            }

            return itemDictionary;
        }

    }
}
