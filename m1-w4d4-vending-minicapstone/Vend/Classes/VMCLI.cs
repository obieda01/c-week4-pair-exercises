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
                while (true)
                {

                try
                {
                    Console.WriteLine("\n(1) Display Vending Machine Items");
                    Console.WriteLine("(2) Purchase ");
                    int mainMenue = int.Parse(Console.ReadLine());//

                    if (mainMenue == 1)
                    {
                        printAllItems(techElevatorMachine);

                    }
                    else if (mainMenue == 2)
                    {
                        processMenuSelections(techElevatorMachine);

                    }
                    else if (mainMenue == 0)
                    {
                        printSales();
                    }
                    else
                    {
                        break;
                    }

                }
                catch (Exception )
                {
                    Console.WriteLine("Please input integer values\n\n");
                }
            }
          
         
        }
        public void printSales()
        {
            ReportWriter reportWriter = new ReportWriter();
            reportWriter.readWriteFile();

        }
        public void printAllItems(VendMachine techElevatorMachine)
        {
            Console.WriteLine("Slot".PadRight(20) + "Items:".PadRight(20) + "Price:".PadRight(20) + "Quantity:");

            foreach (KeyValuePair<string, VendMachineItems> kvp in techElevatorMachine.ItemDictionary)
            {
                Console.WriteLine(kvp.Key.PadRight(20) + kvp.Value.ItemName.PadRight(20) + kvp.Value.ItemPrice.ToString().PadRight(20) + kvp.Value.ItemCount);
            }
        }

        public void processMenuSelections(VendMachine techElevatorMachine)
        {
            while (true)
            {
                
                Console.WriteLine("(1) Feed Money\n(2) Select Product\n(3) Finish Transaction ");
                int processMenu = int.Parse(Console.ReadLine());//
                if (processMenu == 1)
                {
                    try
                    {
                        Console.WriteLine("Please input Dollar amounts (e.g.1,2,5,10) :");
                        techElevatorMachine.Balance = double.Parse(Console.ReadLine());//
                        Console.WriteLine("Your current balance is: $" + techElevatorMachine.Balance + "\n");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("\n Please input integer value for dollar amount\n");
                    }
                }
                else if (processMenu == 2)
                {
                    Console.WriteLine("Please select Product by slots displayed:");
                    string selectedItem = Console.ReadLine();

                    if (!techElevatorMachine.ItemDictionary.ContainsKey(selectedItem))
                    {
                        Console.WriteLine("The Item selected is unfortunately does not exist. ");
                        break;
                    }
                    if (techElevatorMachine.ItemDictionary[selectedItem].ItemCount == 0)
                    {
                        Console.WriteLine("The Item selected is unfortunately out of stock. ");
                        break;
                    }
                    if (techElevatorMachine.Balance < techElevatorMachine.ItemDictionary[selectedItem].ItemPrice)
                    {
                        Console.WriteLine("Balance is insuficient.\n"+techElevatorMachine.Balance);//
                        this.processMenuSelections(techElevatorMachine);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Item has been dispensed. \n");

                        double value = techElevatorMachine.Balance;
                        techElevatorMachine.Balance -= techElevatorMachine.ItemDictionary[selectedItem].ItemPrice;
                        Console.WriteLine("Your current balance is: $" + techElevatorMachine.Balance + "\n");
                        techElevatorMachine.ItemDictionary[selectedItem].ItemCount = techElevatorMachine.ItemDictionary[selectedItem].ItemCount - 1;
                        AuditLog ad = new AuditLog();
                            ad.writeToLog(techElevatorMachine.ItemDictionary[selectedItem].ItemName
                            , techElevatorMachine.ItemDictionary[selectedItem].ItemSlot,
                            value
                            , techElevatorMachine.ItemDictionary[selectedItem].ItemPrice,techElevatorMachine.Balance);
                           
                        break;
                    }

                }
                else if (processMenu == 3)
                {
                    Console.WriteLine("Thank you for shopping, your change is " + "$" + techElevatorMachine.Balance);
                    calculateChange(techElevatorMachine.Balance);
                    techElevatorMachine.Balance = 0;
                    break;


                }
            }
        }

        public void calculateChange(double change)
        {
            double pennies =  change * 100;
            int cents = (int)pennies;
            int remainingQuarters = cents - ((cents / 25) * 25);
            int quarters = cents / 25;
            int dimesRemaining = remainingQuarters - ((remainingQuarters / 10) * 10);
            int dimes = ((remainingQuarters / 10) );

            int nicklesRemaining = dimesRemaining - ((dimesRemaining / 5) * 5);
            int nickles = ((dimesRemaining / 5) );

            Console.WriteLine($"Your change is  {quarters} Quarters, {dimes} Dimes, {nickles} Nickles and {nicklesRemaining} Pennies");
        }
    }
}
