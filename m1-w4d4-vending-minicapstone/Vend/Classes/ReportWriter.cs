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
        public void readWriteFile()
        {
            ItemReader rd = new ItemReader();
            Dictionary<string, int> dictionaryOfItemSale = new Dictionary<string, int>();
            foreach (KeyValuePair< string, VendMachineItems > kvp in rd.fileReaderCSV())
            {
                dictionaryOfItemSale.Add(kvp.Key, 0);
            }

            using (StreamReader sr = new StreamReader(Path.Combine(Environment.CurrentDirectory, "TransactionLog.txt")))
            {
                while (!sr.EndOfStream)
                {
                    string[] lineContent = sr.ReadLine().Split('|');
                    dictionaryOfItemSale[lineContent[2]]++;

                }
            }
            String fileName = "VendoMaticSales.csv";
          
            using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.CurrentDirectory,fileName), true))
            {
                double totalSales = 0;
                foreach (KeyValuePair<string, int> kvp in dictionaryOfItemSale)
                {
                  
                    sw.WriteLine( kvp.Key+"|"+ rd.ItemDictionary[kvp.Key].ItemName + "|" +kvp.Value.ToString() + "|" + (kvp.Value * rd.ItemDictionary[kvp.Key].ItemPrice).ToString());
                    totalSales = totalSales+(kvp.Value * rd.ItemDictionary[kvp.Key].ItemPrice) ;
                }

                sw.WriteLine("\n\n***** Summary of total gross sales****");
                sw.WriteLine(totalSales.ToString());
            }
          //  File.Move("VendoMaticSales.csv", "VendoMaticSales_"+ string.Format("{0_HH_mm_ss_tt}", DateTime.Now) + ".csv");
        }
    }
}
