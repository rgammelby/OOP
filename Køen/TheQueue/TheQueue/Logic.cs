using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQueue
{
    public class Logic
    {
        // model and gui news
        Model m = new Model();
        GUI g = new GUI();

        // initializes guest queue and starts main program loop
        public void Start()
        {
            m.InitializeGuests();

            while (true)
            {
                g.Menu();
                Selection();
                g.Restart();
            }
        }

        // lets user choose an action
        public void Selection()
        {
            var selection = g.Input();

            switch (selection)
            {
                // Add items
                case ConsoleKey.D1:
                    NewGuestData();
                    break;

                // Delete items
                case ConsoleKey.D2:
                    m.AdvanceQueue();
                    break;

                // Show number of items
                case ConsoleKey.D3:
                    g.PrintGuestAmount(m.GetGuestAmount());
                    break;

                // Show min and max items (as applicable)
                case ConsoleKey.D4:
                    GetAndPrintHighestAndLowest();
                    break;
                    
                // Find an item
                case ConsoleKey.D5:
                    GetGuestInfo();
                    break;
                    
                // Print all items
                case ConsoleKey.D6:
                    var gu = m.GetGuests();
                    g.PrintAllGuests(gu);
                    break;
                    
                // Exit
                case ConsoleKey.D7:
                    Environment.Exit(0);
                    break;
            }
        }

        public void NewGuestData()
        {
            // prompts user for guest info
            g.AddGuest();

            // accepts user info (guest data)
            string name = g.GuestString();
            byte roomno = g.GuestByte();

            // adds new guest to the queue
            m.AddGuest(name, roomno);
        }

        // retrieves highest and lowest values (room number)
        public void GetAndPrintHighestAndLowest()
        {
            byte highest = m.GetHighestRoomNumber();
            byte lowest = m.GetLowestRoomNumber();

            // prints highest and lowest values (room number)
            g.PrintHighestAndLowest(highest, lowest);
        }

        // takes user input to find a specific guest
        public void GetGuestInfo()
        {
            // prompts user for input (name or room number)
            g.PrintGuestPrompt();

            // accepts user input
            var info = g.GuestString();

            // if user input starts with a digit, read as byte
            if (char.IsDigit(info[0]))
            {
                GetGuest("", Convert.ToByte(info));
            }
            // else read as string
            else
            {
                GetGuest(info);
            }
        }

        // retrieves guest info
        public void GetGuest(string name = "", byte roomno = 0)
        {
            var guest = new Model.Guest();

            // if method is called with NAME but NO room number, call GetGuest(string)
            if (name != "" && roomno == 0)
                guest = m.GetGuest(name);
            // if method is called with ROOM NUMBER but NO name, call GetGuest(byte)
            else
                guest = m.GetGuest(roomno);

            // if no guest is found, print error
            if (guest._name == null && guest._roomno == 0)
                g.NoGuestError();
            // if guest is found, print guest
            else
                g.PrintGuest(guest);
        }
    }
}
