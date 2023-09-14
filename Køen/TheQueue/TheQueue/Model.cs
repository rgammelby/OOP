using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static TheQueue.Model;

namespace TheQueue
{
    public class Model
    {
        // the Guest could (and probably should) have been a class, but we wanted to understand structs a little better
        public struct Guest
        {
            public string _name { get; set; }
            public byte _roomno { get; set; }

            public Guest(string name, byte roomno)
            {
                _name = name;
                _roomno = roomno;
            }
        }

        // queue declaration
        Queue<Guest> guests = new Queue<Guest>();

        // guest queue initialization
        public void InitializeGuests()
        {
            guests.Enqueue(new Guest("Peter", 1));
            guests.Enqueue(new Guest("Mikkel", 2));
            guests.Enqueue(new Guest("Emma", 3));
            guests.Enqueue(new Guest("Bo", 4));
            guests.Enqueue(new Guest("Sascha", 5));
        }

        // adds a guest with passed name and room number (byte)
        public void AddGuest(string name, byte roomno)
        {
            guests.Enqueue(new Guest(name, roomno));
        }

        // removes first entry of guest queue
        public void AdvanceQueue()
        {
            guests.Dequeue();
        }

        // returns amount of guests in the queue
        public byte GetGuestAmount()
        {
            return (byte)guests.Count();
        }

        // returns highest room number currently in use by a guest
        public byte GetHighestRoomNumber()
        {
            byte b = 0;

            foreach (Guest guest in guests)
            {
                if (guest._roomno > b)
                    b = guest._roomno;
            }

            return b;
        }

        // returns lowest room number currently in use by a guest
        public byte GetLowestRoomNumber()
        {
            byte b = 255;

            foreach (Guest guest in guests)
            {
                if (guest._roomno < b)
                    b = guest._roomno;
            }

            return b;
        }

        // returns information of a guest (found by string parameter)
        public Guest GetGuest(string name)
        {
            Guest g = new Guest();
            foreach (Guest guest in guests)
            {
                if (guest._name == name)
                    g = guest;
            }

            return g;
        }

        // returns information of a guest (found by byte parameter)
        public Guest GetGuest(byte roomno)
        {
            Guest g = new Guest();
            foreach (Guest guest in guests)
            {
                if (guest._roomno == roomno)
                {
                    g = guest;
                }
            }
            return g;
        }

        // returns full queue of guests
        public Queue<Guest> GetGuests()
        {
            return guests;
        }
    }
}
