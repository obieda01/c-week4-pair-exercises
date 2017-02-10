using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vend.Classes
{
    public class ReportWriter
    {
        private Dictionary<string, int> dictionaryOfItemSale=new Dictionary<string, int>();

        public Dictionary<string, int> DictionaryOfItemSale
        {
            get { return dictionaryOfItemSale; }
        }

        public void readWriteFile()
        {
            ItemReader rd = new ItemReader();
           
            foreach (KeyValuePair< string, VendMachineItems > kvp in rd.fileReaderCSV())
            {
                DictionaryOfItemSale.Add(kvp.Key, 0);
            }

            using (StreamReader sr = new StreamReader(Path.Combine(Environment.CurrentDirectory, "TransactionLog.txt")))
            {
                while (!sr.EndOfStream)
                {
                    string[] lineContent = sr.ReadLine().Split('|');
                    DictionaryOfItemSale[lineContent[2]]++;

                }
            }
            String fileName = string.Concat(
            Path.GetFileNameWithoutExtension("VendoMaticSales.csv"),
            DateTime.Now.ToString("yyyyMMddHHmmssfff"),
            Path.GetExtension("VendoMaticSales.csv")
            );

            using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.CurrentDirectory,fileName), true))
            {
                double totalSales = 0;
                foreach (KeyValuePair<string, int> kvp in DictionaryOfItemSale)
                {
                  
                    sw.WriteLine(rd.ItemDictionary[kvp.Key].ItemName + "|" +kvp.Value.ToString() );
                    totalSales = totalSales+(kvp.Value * rd.ItemDictionary[kvp.Key].ItemPrice) ;
                }

                sw.WriteLine("\n\n***** Summary of total gross sales is : "+ totalSales.ToString() + "****");
            }
         
        }
    }
}
