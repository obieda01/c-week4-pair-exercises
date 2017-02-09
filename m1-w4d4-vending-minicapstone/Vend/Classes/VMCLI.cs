using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vend.Classes
{
    public class VMCLI
    {
        public VMCLI(VendMachine techElevatorMachine)
        {
            launchRun(techElevatorMachine);
        }

        public void launchRun(VendMachine techElevatorMachine)
        {
            bool isRunning = false;
            while (!isRunning)
            {

                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase ");
                int mainMenue = int.Parse(Console.ReadLine());

                if (mainMenue == 1)
                {
                    printAllItems(techElevatorMachine);
                }
                else if (mainMenue == 2)
                {

                }
                else if (mainMenue == 0)
                {

                }
                else 
                {
                    Console.WriteLine("Please select one of the displayed options. ");
                }
                


            }
        }
        public void printAllItems(VendMachine techElevatorMachine)
        {

        }
    }
}
