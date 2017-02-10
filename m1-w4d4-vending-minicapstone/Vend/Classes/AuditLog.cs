using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Vend.Classes
{
   public class AuditLog
    {

        public void writeToLog(string item, string slot, double balance, double price, double change)
        {

            using (StreamWriter sw = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "TransactionLog.txt"),true))
            {
                string line = string.Format("{0:MM/dd/yy HH:mm:ss tt}", DateTime.Now) +"|"+
                    item+"|" + slot + "|" + balance.ToString() + "|" + price.ToString() + "|"
                    + change.ToString();
                sw.WriteLine(line);
            }
        }
    }
}
