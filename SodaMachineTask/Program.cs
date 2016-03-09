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
            sodamachine.AddGrapeSodaToMachine(1);
            sodamachine.AddOrangeSodaToMachine(1);
            sodamachine.AddMeatSodaToMachine(1);
            sodamachine.AddCoinsToSodaMachine(20, 10, 20, 50);
            sodamachine.GetUserCoins(customer);
            Console.ReadLine();
        }
    }
}
