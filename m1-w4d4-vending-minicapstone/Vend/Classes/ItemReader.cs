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
        private  Dictionary<string,string> itemDictionary;

        public  Dictionary<string,string> ItemDictionary 
        {
            get { return itemDictionary; }
            //set { itemDictionary = value; }
        }

        public  Dictionary<string,string>  fileReaderCSV()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Path.Combine(Environment.CurrentDirectory, "vendingmachine.csv")))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] lineSplitter= sr.ReadLine().Split('|');
                        ItemDictionary.Add(lineSplitter[0], lineSplitter[1] + " " + lineSplitter[2]);
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
