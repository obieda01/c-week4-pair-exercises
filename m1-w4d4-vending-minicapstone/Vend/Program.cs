using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vend.Classes;
namespace Vend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ItemReader itemReader = new ItemReader();
            VendMachineItems vendItems = new VendMachineItems(itemReader);
            VendMachine machine = new VendMachine(vendItems);
        }
    }
}
