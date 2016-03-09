using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineTask
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaMachine sodamachine = new SodaMachine();
            Customer customer = new Customer();
            sodamachine.AddGrapeSodaToMachine(20);
            sodamachine.AddOrangeSodaToMachine(20);
            sodamachine.AddMeatSodaToMachine(20);
            sodamachine.AddCoinsToSodaMachine(20, 10, 20, 50);
            sodamachine.GetUserCoins(customer);
            Console.ReadLine();
        }
    }
}
