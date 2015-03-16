using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_Airline_Reservations
{
    class Airplane
    {
        private bool[] seats;

        public Airplane()
        {
            seats = new bool[10]; // first class seating is 1-5 and economy is 6-10
        }

        // returns true if the seat has been assigned or false if it's full
        public bool AssignSeat(int travelClass)
        {
            // first-class
            if (travelClass == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (seats[i] == false)
                    {
                        seats[i] = true;
                        return true;
                    }
                }
            }
            else // economy class
            {
                for (int i = 5; i < 10; i++)
                {
                    if (seats[i] == false)
                    {
                        seats[i] = true;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
