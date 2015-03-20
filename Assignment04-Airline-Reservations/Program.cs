///------------------------------------------------------------------------------------------
///   Project:              Assignment 04 - Airline Reservations System
/// 
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   March 15, 2015
///   
///   Program description:  A program that displays a menu with 3 options. If the user selects
///                         a seat that is not available then they are offered the alternative
///                         or can wait 3 hours for the next flight.
///                         
///   Revision History:     2015-03-15: Initial build
///                         2015-03-15: Added the main menu
///                         2015-03-15: Added an airplane class
///                         2015-03-20: Finished the airplane class and the main program
///                         2015-03-20: Added documentation
///------------------------------------------------------------------------------------------

using System;

namespace Assignment04_Airline_Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        // displays a menu that loops until the user chooses to exit
        private static void MainMenu()
        {
            int selection = 0; // default selection
            Airplane airPlane = new Airplane();

            while (selection != 3)
            {
                Console.WriteLine("********************************");
                Console.WriteLine("*                              *");
                Console.WriteLine("*  1. First class              *");
                Console.WriteLine("*  2. Economy Class            *");
                Console.WriteLine("*  3. Exit                     *");
                Console.WriteLine("*                              *");
                Console.WriteLine("********************************");
                Console.Write("Please make your selection: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    selection = 0;
                }

                airPlane.AssignSeat(selection);

                WaitForKey();
                Console.Clear(); // Clears the screen
            }
        }

        // pauses the program and waits for the user to continue
        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Press any key to continue...");
            Console.WriteLine("----------------------------");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
