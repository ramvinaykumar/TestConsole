//-------------------------------------------------------------------------------------------------
//
// InternationalFormat.cs -- The InternationalFormat class.
//
// Copyright (c) 2020. All rights reserved.
//
//-------------------------------------------------------------------------------------------------

using System;

namespace TestConsole
{
    //----------------------------------------------------------------------------------------------
    /// <summary>
    /// International Number Format
    /// </summary>
    public static class InternationalFormat
    {
        #region Variable

        static string[] unitsMap = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] tensMap = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        #endregion

        #region Method

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Number To Words
        /// </summary>
        /// <param name="number">Int64 number</param>
        /// <returns>Return the number as word</returns>
        public static string NumberToWords(Int64 number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += NumberToWords(number / 1000000000) + " Billion ";
                number %= 1000000000;
            }

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }

            return words;
        }

        #endregion
    }
}
