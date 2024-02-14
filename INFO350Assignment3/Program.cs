/*
 * INFO 350 - Assignment 2
 * 
 * <replace with your name>
 * 
 * Computer Club Proceeds
 * 
 * Write a program in C# that computes the amount of money the computer club will
 * receive from proceeds of their granola bar sales project. 
 * 
 * Modify this code to complete this assignment
 */


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;

            Console.WriteLine("Type in something: ");

            // reads in a string from the console
            inputString = Console.ReadLine();

            // checks that we got a string back instead of a null
            // note we have not covered null yet
            if (inputString == null)
            {
                Console.WriteLine("Incorrect input, exiting");
                return;
            }

            /*
             * Validate the input
             * 
             * You need to make sure that the inputs are reasonable
             */



            /*
             * Calculate the proceeds by calling a method you create
             */


            /*
             * note that below, the " is escaped as \" such that the compiler
             * doesn't mistake it for the end of the string
             */
            Console.WriteLine("You typed in \"" + inputString + "\"");
        }
    }
}