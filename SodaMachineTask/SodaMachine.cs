using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineTask
{
    public class SodaMachine
    {
        List<Coin> machineCoins = new List<Coin>();
        List<Soda> machineGrapeCans = new List<Soda>();
        List<Soda> machineOrangeCans = new List<Soda>();
        List<Soda> machineMeatCans = new List<Soda>();
        public SodaMachine()
        {

        }
        public void AddGrapeSodaToMachine(int numberOfGrapeSodas)
        {
            for (int i = 0; i < numberOfGrapeSodas; i++)
            {
                machineGrapeCans.Add(new Soda("grape", 60));
            }
        }

        public void AddOrangeSodaToMachine(int numberOfOrangeSoda)
        {
            for (int i = 0; i < numberOfOrangeSoda; i++)
            {
                machineOrangeCans.Add(new Soda("orange", 35));
            }
        }
        public void AddMeatSodaToMachine(int numberOfMeatSoda)
        {
            for (int i = 0; i < numberOfMeatSoda; i++)
            {
                machineMeatCans.Add(new Soda("meat", 6));
            }
        }

        public void AddCoinsToSodaMachine(int numberOfQuarters, int numberOfDimes, int numberOfNickels, int numberOfPennies)
        {
            for (int i = 0; i < numberOfQuarters; i++)
            {
                machineCoins.Add(new Quarter(25));
            }
            for (int i = 0; i < numberOfDimes; i++)
            {
                machineCoins.Add(new Dime(10));
            }
            for (int i = 0; i < numberOfNickels; i++)
            {
                machineCoins.Add(new Nickel(5));
            }
            for (int i = 0; i < numberOfPennies; i++)
            {
                machineCoins.Add(new Penny(1));
            }
        }
        public void GetUserCoins(Customer customer)
        {
            string userCoinEntry = "";
            while (userCoinEntry != "E")
            {
                Console.WriteLine("Enter 'P' to insert a Penny");
                Console.WriteLine("Enter 'N' to insert a Nickel");
                Console.WriteLine("Enter 'D' to insert a Dime");
                Console.WriteLine("Enter 'Q' to insert a Quarter");
                Console.WriteLine("Enter 'F' to finish inserting coins and choose soda flavor.");
                Console.WriteLine("Enter 'E' to Exit.");
                userCoinEntry = Console.ReadLine();
                Console.Clear();
                switch (userCoinEntry)
                {
                    case "P":
                        try {
                            Console.WriteLine("How many pennies do you want to enter?");
                            string enteredNumberOfPennies = Console.ReadLine();
                            for (int i = 0; i <= int.Parse(enteredNumberOfPennies); i++)
                            {
                                customer.customerCoins.Add(new Penny(1));
                            }
                        }
                        catch
                        {
                            Console.WriteLine("That is not a correct number, try again.");
                        }
                        break;
                    case "N":
                        try {
                            Console.WriteLine("How many nickels do you want to enter?");
                            string enteredNumberOfNickels = Console.ReadLine();
                            for (int i = 0; i <= int.Parse(enteredNumberOfNickels); i++)
                            {
                                customer.customerCoins.Add(new Nickel(5));
                            }
                        }
                        catch
                        {
                            Console.WriteLine("That is not a correct number, try again.");
                        }
                        break;
                    case "D":
                        try {
                            Console.WriteLine("How many dimes do you want to enter?");
                            string enteredNumberOfDimes = Console.ReadLine();
                            for (int i = 0; i < int.Parse(enteredNumberOfDimes); i++)
                            {
                                customer.customerCoins.Add(new Dime(10));
                            }
                        }
                        catch
                        {
                            Console.WriteLine("That is not a correct number, try again.");
                        }
                        break;
                    case "Q":
                        try {
                            Console.WriteLine("How many quarters do you want to enter?");
                            string enteredNumberOfQuarters = Console.ReadLine();
                            for (int i = 0; i < int.Parse(enteredNumberOfQuarters); i++)
                            {
                                customer.customerCoins.Add(new Quarter(25));
                            }
                        }
                        catch
                        {
                            Console.WriteLine("That is not a correct number, try again.");
                        }
                        break;
                    case "F":
                        Console.WriteLine("Moving on to flavor choice.");
                        Vend(customer);
                        break;
                    case "E":
                        Console.WriteLine("Exiting.");
                        break;
                    default:
                        Console.WriteLine("Not a valid choice. Try again.");
                        break;
                }
            }
        }
        public void Vend(Customer customer)
        {
            int GrapeSodaCost = 65;
            int OrangeSodaCost = 35;
            int MeatSodaCost = 6;
            int UserCoins;
            Console.WriteLine("Choose soda flavor: 'G' for Grape  (60 cents)");
            Console.WriteLine("Choose soda flavor: 'O' for Orange (35 cents)");
            Console.WriteLine("Choose soda flavor: 'M' for Meat flavor (6 cents)");
            Console.WriteLine("Choose 'E' to go back and Exit.");
            string userSodaChoice = Console.ReadLine();
            UserCoins = GetUserCoinTotal(customer);
            switch (userSodaChoice)
            {
                case "G":
                    //should make a method to get soda costs below rather than set in local above.
                    if (UserCoins == GrapeSodaCost)
                    {
                        try {
                            Console.WriteLine("Grape Soda dispensing.");
                            //should make the below a seperate method, and do the try catch in that.
                            machineGrapeCans.RemoveAt(0);
                            customer.customerCans.Add(machineGrapeCans[0]);
                            Vend(customer);
                        }
                        catch
                        {
                            Console.WriteLine("Insufficient amount of cans");
                        }
                    }
                    else if(UserCoins > GrapeSodaCost)
                    {
                        try {
                            Console.WriteLine("Grape Soda dispensing with customer change.");
                            customer.customerCans.Add(machineGrapeCans[0]);
                            machineGrapeCans.RemoveAt(0);
                            Vend(customer);
                        }
                        catch
                        {
                            Console.WriteLine("Insufficient amount of cans.");
                        }
                    }
                    else if (UserCoins < GrapeSodaCost)
                    {
                        Console.WriteLine("You have insufficient funds.");
                    }
                    break;
                case "O":
                    if (UserCoins == OrangeSodaCost)
                    {
                        try {
                            Console.WriteLine("Orange Soda dispensing.");
                            machineOrangeCans.RemoveAt(0);
                            customer.customerCans.Add(machineOrangeCans[0]);
                            Vend(customer);
                        }
                        catch
                        {
                            Console.WriteLine("Insufficient amount of cans.");
                        }
                    }
                    else if (UserCoins > OrangeSodaCost)
                    {
                        try {
                            Console.WriteLine("Orange Soda dispensing with customer change.");
                            machineOrangeCans.RemoveAt(0);
                            customer.customerCans.Add(machineOrangeCans[0]);
                            Vend(customer);
                        }
                        catch
                        {
                            Console.WriteLine("Insufficient amount of cans.");
                        }
                    }
                    else if (UserCoins < OrangeSodaCost)
                    {
                        Console.WriteLine("You have insufficient funds.");
                    }
                    break;
                case "M":
                    if (UserCoins == MeatSodaCost)
                    {
                        try {
                            Console.WriteLine("Meat Soda dispensing.");
                            machineMeatCans.RemoveAt(0);
                            customer.customerCans.Add(machineMeatCans[0]);
                            Vend(customer);
                        }
                        catch
                        {
                            Console.WriteLine("Insufficient amount of cans.");
                        }
                    }
                    else if (UserCoins > MeatSodaCost)
                    {
                        try {
                            Console.WriteLine("Meat Soda dispensing with customer change.");
                            machineMeatCans.RemoveAt(0);
                            customer.customerCans.Add(machineMeatCans[0]);
                            Vend(customer);
                        }
                        catch
                        {
                            Console.WriteLine("Insufficient amount of cans.");
                        }
                    }
                    else if (UserCoins < MeatSodaCost)
                    {
                        Console.WriteLine("You have insufficient funds.");
                    }
                    break;
                case "E":
                    Console.WriteLine("Going Back.");
                    break;
                default:
                    Console.WriteLine("Incorrect entry, try again.");
                    break;
            }
        }
        public int GetUserCoinTotal(Customer customer)
        {
            int UserCoinTotal = 0;
            foreach (Coin item in customer.customerCoins)
            {
                UserCoinTotal += item.coinValue;
            }
            return UserCoinTotal;
        }
        public void MakeChange(Customer customer, Soda soda)
        {
            for (int i = 0; i < machineCoins.Count; i++)
            {
                
            }
        }
    }
}
