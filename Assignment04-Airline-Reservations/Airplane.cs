using System;

namespace Assignment04_Airline_Reservations
{
    class Airplane
    {
        private bool[] seats;

        public Airplane()
        {
            seats = new bool[10]; // first class seating is 1-5 and economy is 6-10
        }

        // returns the index of a seat that's empty or -1 if none are empty
        private int CheckSeats(int index, int length)
        {
            for (int i = index; i < length; i++)
            {
                if (seats[i] == false)
                {
                    return i; //returns the index of the seat
                }
            }

            return -1; //none of the seats are empty in the given length
        }

        // Assigns a seat based on the selection and if chosen class is full then the user can select the other class or not
        public void AssignSeat(int travelClass)
        {
            int seatNum;

            switch (travelClass)
            {
                case 1: // first-class
                    seatNum = CheckSeats(0, 5);

                    if (seatNum != -1)
                    {
                        seats[seatNum] = true;
                        Console.WriteLine("\nSuccesfully added you to first-class seating.");
                    }
                    else // if first-class section is full
                    {
                        if (CheckSeats(5, 10) != -1) //checks to see if the seats in the economy-class are full
                        {
                            Console.Write("Sorry, but all the first class seats are taken. Would you like to be placed in the economy class? (Y/N): ");
                            AssignSeat(Console.ReadKey().Key == ConsoleKey.Y ? 2 : 5);
                        }
                        else
                        {
                            //if all the seats are taken
                            AssignSeat(4);
                        }
                    }
                    break;
                case 2: // economy-class
                    seatNum = CheckSeats(5, 10);

                    if (seatNum != -1)
                    {
                        seats[seatNum] = true;
                        Console.WriteLine("\nSuccesfully added you to economy-class seating.");
                    }
                    else // if economy-class section is full
                    {
                        if (CheckSeats(0, 5) != -1) //checks to see if the seats in the first-class are full
                        {
                            Console.Write("Sorry, but all the economy class seats are taken. Would you like to be placed in the first class? (Y/N): ");
                            AssignSeat(Console.ReadKey().Key == ConsoleKey.Y ? 1 : 5);
                        }
                        else
                        {
                            //if all the seats are taken
                            AssignSeat(4);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Thank you for choosing Error Canada. Your flight is guaranteed to be late or your money stolen.");
                    break;
                case 4:
                    Console.WriteLine("Sorry, but all the seats are taken in both first-class and economy-class seating. Next flight leaves in 3 hours.");
                    break;
                case 5:
                    Console.WriteLine("Next flight leaves in 3 hours.");
                    break;
                default:
                    Console.WriteLine("Error: Please enter a valid input.");
                    break;
            }
        }
    }
}
