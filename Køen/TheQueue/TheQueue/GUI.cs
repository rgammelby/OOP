using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQueue
{
    public class GUI
    {
        // displays user options
        public void Menu()
        {
            Console.WriteLine(
                "  _   _  ___ _____ _____ _        ___  _   _ _____ _   _ _____ \r\n" +
                " | | | |/ _ \\_   _| ____| |      / _ \\| | | | ____| | | | ____|\r\n" +
                " | |_| | | | || | |  _| | |     | | | | | | |  _| | | | |  _|  \r\n" +
                " |  _  | |_| || | | |___| |___  | |_| | |_| | |___| |_| | |___ \r\n" +
                " |_| |_|\\___/ |_| |_____|_____|  \\__\\_\\\\___/|_____|\\___/|_____|\n\n");

            Console.WriteLine("(1) Add items \n" +
                "(2) Delete items \n" +
                "(3) Show the number of items \n" +
                "(4) Show the min and max items \n" +
                "(5) Find an item \n" +
                "(6) Print all items \n" +
                "(7) Exit \n");
        }

        // prints an error if no guest is retrieved
        public void NoGuestError()
        {
            Console.WriteLine("There is no guest at this hotel with that name or room number. ");
        }

        // prompts user to input name and room number for new guest
        public void AddGuest()
        {
            Console.WriteLine("Please type in the name and room number of the guest you would like to add to the queue: \n" +
                "Name:");
        }

        // prints list of all guests in the queue
        public void PrintAllGuests(Queue<Model.Guest> g)
        {
            foreach (var guests in g)
            {
                Console.WriteLine($"Name: {guests._name} \n" +
                    $"Room number: {guests._roomno} \n");
            }
        }

        // prints the highest and lowest room numbers currently in use
        public void PrintHighestAndLowest(byte highest, byte lowest)
        {
            Console.WriteLine($"Highest room number currently in use: {highest} \n" +
                $"Lowest room number currently in use: {lowest} \n");
        }

        // prints info associated with a guest
        public void PrintGuest(Model.Guest guest)
        {
            Console.WriteLine($"Name: {guest._name} \n" +
                $"Room number: {guest._roomno} \n");
        }

        // prompts user to enter name or room of desired guest
        public void PrintGuestPrompt()
        {
            Console.WriteLine("Please enter the name or room number of the guest you are looking for: \n");
        }

        // clears the console upon user input
        public void Restart()
        {
            Console.ReadLine();
            Console.Clear();
        }
        
        // prints amount of guests currently in the queue
        public void PrintGuestAmount(byte amount)
        {
            Console.WriteLine($"There are {amount} guests currently staying at the hotel. \n");
        }

        // accepts user input (key)
        public ConsoleKey Input()
        {
            var selection = Console.ReadKey(true).Key;

            return selection;
        }

        // accepts string user input
        public string GuestString()
        {
            return Console.ReadLine();
        }

        // accepts byte user input
        public byte GuestByte()
        {
            return byte.Parse(Console.ReadLine());
        }
    }
}
