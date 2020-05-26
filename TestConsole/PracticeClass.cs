using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public static class PracticeClass
    {
        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Convert Digit To Words
        /// </summary>
        /// <param name="inputNumber">Int64 inputNumber</param>
        /// <returns>Convert Digit To Words into string</returns>
        public static string ConvertDigitToWords(Int64 inputNumber)
        {
            string wordResult = "";
            if ((inputNumber >= 1) && (inputNumber <= 10))
            {
                if ((inputNumber % 10) == 1) wordResult = "One";
                if ((inputNumber % 10) == 2) wordResult = "Two";
                if ((inputNumber % 10) == 3) wordResult = "Three";
                if ((inputNumber % 10) == 4) wordResult = "Four";
                if ((inputNumber % 10) == 5) wordResult = "Five";
                if ((inputNumber % 10) == 6) wordResult = "Six";
                if ((inputNumber % 10) == 7) wordResult = "Seven";
                if ((inputNumber % 10) == 8) wordResult = "Eight";
                if ((inputNumber % 10) == 9) wordResult = "Nine";
                if ((inputNumber % 10) == 0) wordResult = "Ten";
            }
            if (inputNumber > 9 && inputNumber < 20)
            {
                if (inputNumber == 11) wordResult = "Eleven";
                if (inputNumber == 12) wordResult = "Twelve";
                if (inputNumber == 13) wordResult = "Thirteen";
                if (inputNumber == 14) wordResult = "Forteen";
                if (inputNumber == 15) wordResult = "Fifteen";
                if (inputNumber == 16) wordResult = "Sixteen";
                if (inputNumber == 17) wordResult = "Seventeen";
                if (inputNumber == 18) wordResult = "Eighteen";
                if (inputNumber == 19) wordResult = "Nineteen";
            }
            if (inputNumber > 20 && (inputNumber / 10) == 2 && (inputNumber % 10) == 0) wordResult = "Twenty";
            if (inputNumber > 20 && (inputNumber / 10) == 3 && (inputNumber % 10) == 0) wordResult = "Thirty";
            if (inputNumber > 20 && (inputNumber / 10) == 4 && (inputNumber % 10) == 0) wordResult = "Forty";
            if (inputNumber > 20 && (inputNumber / 10) == 5 && (inputNumber % 10) == 0) wordResult = "Fifty";
            if (inputNumber > 20 && (inputNumber / 10) == 6 && (inputNumber % 10) == 0) wordResult = "Sixty";
            if (inputNumber > 20 && (inputNumber / 10) == 7 && (inputNumber % 10) == 0) wordResult = "Seventy";
            if (inputNumber > 20 && (inputNumber / 10) == 8 && (inputNumber % 10) == 0) wordResult = "Eighty";
            if (inputNumber > 20 && (inputNumber / 10) == 9 && (inputNumber % 10) == 0) wordResult = "Ninty";

            if (inputNumber > 20 && (inputNumber / 10) == 2 && (inputNumber % 10) != 0)
            {
                if ((inputNumber % 10) == 1) wordResult = "Twenty One";
                if ((inputNumber % 10) == 2) wordResult = "Twenty Two";
                if ((inputNumber % 10) == 3) wordResult = "Twenty Three";
                if ((inputNumber % 10) == 4) wordResult = "Twenty Four";
                if ((inputNumber % 10) == 5) wordResult = "Twenty Five";
                if ((inputNumber % 10) == 6) wordResult = "Twenty Six";
                if ((inputNumber % 10) == 7) wordResult = "Twenty Seven";
                if ((inputNumber % 10) == 8) wordResult = "Twenty Eight";
                if ((inputNumber % 10) == 9) wordResult = "Twenty Nine";
            }
            if (inputNumber > 20 && (inputNumber / 10) == 3 && (inputNumber % 10) != 0)
            {
                if ((inputNumber % 10) == 1) wordResult = "Thirty One";
                if ((inputNumber % 10) == 2) wordResult = "Thirty Two";
                if ((inputNumber % 10) == 3) wordResult = "Thirty Three";
                if ((inputNumber % 10) == 4) wordResult = "Thirty Four";
                if ((inputNumber % 10) == 5) wordResult = "Thirty Five";
                if ((inputNumber % 10) == 6) wordResult = "Thirty Six";
                if ((inputNumber % 10) == 7) wordResult = "Thirty Seven";
                if ((inputNumber % 10) == 8) wordResult = "Thirty Eight";
                if ((inputNumber % 10) == 9) wordResult = "Thirty Nine";
            }
            if (inputNumber > 20 && (inputNumber / 10) == 4 && (inputNumber % 10) != 0)
            {
                if ((inputNumber % 10) == 1) wordResult = "Forty One";
                if ((inputNumber % 10) == 2) wordResult = "Forty Two";
                if ((inputNumber % 10) == 3) wordResult = "Forty Three";
                if ((inputNumber % 10) == 4) wordResult = "Forty Four";
                if ((inputNumber % 10) == 5) wordResult = "Forty Five";
                if ((inputNumber % 10) == 6) wordResult = "Forty Six";
                if ((inputNumber % 10) == 7) wordResult = "Forty Seven";
                if ((inputNumber % 10) == 8) wordResult = "Forty Eight";
                if ((inputNumber % 10) == 9) wordResult = "Forty Nine";
            }
            if (inputNumber > 20 && (inputNumber / 10) == 5 && (inputNumber % 10) != 0)
            {
                if ((inputNumber % 10) == 1) wordResult = "Fifty One";
                if ((inputNumber % 10) == 2) wordResult = "Fifty Two";
                if ((inputNumber % 10) == 3) wordResult = "Fifty Three";
                if ((inputNumber % 10) == 4) wordResult = "Fifty Four";
                if ((inputNumber % 10) == 5) wordResult = "Fifty Five";
                if ((inputNumber % 10) == 6) wordResult = "Fifty Six";
                if ((inputNumber % 10) == 7) wordResult = "Fifty Seven";
                if ((inputNumber % 10) == 8) wordResult = "Fifty Eight";
                if ((inputNumber % 10) == 9) wordResult = "Fifty Nine";
            }
            if (inputNumber > 20 && (inputNumber / 10) == 6 && (inputNumber % 10) != 0)
            {
                if ((inputNumber % 10) == 1) wordResult = "Sixty One";
                if ((inputNumber % 10) == 2) wordResult = "Sixty Two";
                if ((inputNumber % 10) == 3) wordResult = "Sixty Three";
                if ((inputNumber % 10) == 4) wordResult = "Sixty Four";
                if ((inputNumber % 10) == 5) wordResult = "Sixty Five";
                if ((inputNumber % 10) == 6) wordResult = "Sixty Six";
                if ((inputNumber % 10) == 7) wordResult = "Sixty Seven";
                if ((inputNumber % 10) == 8) wordResult = "Sixty Eight";
                if ((inputNumber % 10) == 9) wordResult = "Sixty Nine";
            }
            if (inputNumber > 20 && (inputNumber / 10) == 7 && (inputNumber % 10) != 0)
            {
                if ((inputNumber % 10) == 1) wordResult = "Seventy One";
                if ((inputNumber % 10) == 2) wordResult = "Seventy Two";
                if ((inputNumber % 10) == 3) wordResult = "Seventy Three";
                if ((inputNumber % 10) == 4) wordResult = "Seventy Four";
                if ((inputNumber % 10) == 5) wordResult = "Seventy Five";
                if ((inputNumber % 10) == 6) wordResult = "Seventy Six";
                if ((inputNumber % 10) == 7) wordResult = "Seventy Seven";
                if ((inputNumber % 10) == 8) wordResult = "Seventy Eight";
                if ((inputNumber % 10) == 9) wordResult = "Seventy Nine";
            }
            if (inputNumber > 20 && (inputNumber / 10) == 8 && (inputNumber % 10) != 0)
            {
                if ((inputNumber % 10) == 1) wordResult = "Eighty One";
                if ((inputNumber % 10) == 2) wordResult = "Eighty Two";
                if ((inputNumber % 10) == 3) wordResult = "Eighty Three";
                if ((inputNumber % 10) == 4) wordResult = "Eighty Four";
                if ((inputNumber % 10) == 5) wordResult = "Eighty Five";
                if ((inputNumber % 10) == 6) wordResult = "Eighty Six";
                if ((inputNumber % 10) == 7) wordResult = "Eighty Seven";
                if ((inputNumber % 10) == 8) wordResult = "Eighty Eight";
                if ((inputNumber % 10) == 9) wordResult = "Eighty Nine";
            }
            if (inputNumber > 20 && (inputNumber / 10) == 9 && (inputNumber % 10) != 0)
            {
                if ((inputNumber % 10) == 1) wordResult = "Ninty One";
                if ((inputNumber % 10) == 2) wordResult = "Ninty Two";
                if ((inputNumber % 10) == 3) wordResult = "Ninty Three";
                if ((inputNumber % 10) == 4) wordResult = "Ninty Four";
                if ((inputNumber % 10) == 5) wordResult = "Ninty Five";
                if ((inputNumber % 10) == 6) wordResult = "Ninty Six";
                if ((inputNumber % 10) == 7) wordResult = "Ninty Seven";
                if ((inputNumber % 10) == 8) wordResult = "Ninty Eight";
                if ((inputNumber % 10) == 9) wordResult = "Ninty Nine";
            }
            return wordResult;
        }


        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// Spell The Number
        /// </summary>
        /// <param name="number">Int64 number</param>
        /// <returns>Spell The Number into string</returns>
        public static string SpellTheNumber(Int64 number)
        {
            string returnResult = "";
            Int64 resultValue;
            if ((number / 10000000) > 0)
            {
                resultValue = number / 10000000;
                number = number % 10000000;
                returnResult = returnResult + ' ' + ConvertDigitToWords(resultValue) + " Crore";
            }
            if ((number / 100000) > 0)
            {
                resultValue = number / 100000;
                number = number % 100000;
                returnResult = returnResult + ' ' + ConvertDigitToWords(resultValue) + " Lakh";
            }
            if ((number / 1000) > 0)
            {
                resultValue = number / 1000;
                number = number % 1000;
                returnResult = returnResult + ' ' + ConvertDigitToWords(resultValue) + " Thousand";
            }
            if ((number / 100) > 0)
            {
                resultValue = number / 100;
                number = number % 100;
                returnResult = returnResult + ' ' + ConvertDigitToWords(resultValue) + " Hundred";
            }
            if ((number % 10) >= 0)
            {
                resultValue = number % 100;
                returnResult = returnResult + " " + ConvertDigitToWords(resultValue);
            }
            returnResult = returnResult + ' ' + " Rupees only";
            return returnResult;
        }
    }
}
