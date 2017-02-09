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
            Dictionary<string, VendMachineItems> vendItems = itemReader.fileReaderCSV();
            VendMachine machine = new VendMachine(vendItems);
            VMCLI machineVMCLI = new VMCLI(machine);
        }
    }
}
