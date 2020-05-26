//-------------------------------------------------------------------------------------------------
//
// Program.cs -- The Program class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System;

namespace TestConsole
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// Program Class
    /// </summary>
    class Program
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Main method
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                // Type a numeric argument
                Console.WriteLine("Please enter a numeric argument:");

                // Create a variable and get user input from the keyboard and store it in the variable
                long inputValue = long.Parse(Console.ReadLine());

                Console.WriteLine("Indian number system...");
                Console.WriteLine(PracticeClass.SpellTheNumber(inputValue));

                Console.WriteLine("International number system...");
                Console.WriteLine(InternationalFormat.NumberToWords(inputValue));
                Console.ReadKey();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
