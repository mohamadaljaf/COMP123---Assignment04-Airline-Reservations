///------------------------------------------------------------------------------------------
///   Project:              Assignment 04 - Airline Reservations System
/// 
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   March 15, 2015
///   
///   Program description:  A program that rolls a set of dice for a user-input number of
///                         times and displays the tally of the sum of the two dice rolled.
///                         
///   Revision History:     2015-03-15: Initial build
///                         2015-03-15: Added a Dice class and implemented the rollDice method
///                         2015-03-15: Fixed an issue where the tally numbers were incorrect
///                         2015-03-15: Added documentation
///------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                switch (selection)
                {
                    case 1:
                        // CODE FOR CASE 1
                        break;
                    case 2:
                        // CODE FOR CASE 1
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Error: Please enter a valid input.");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

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
