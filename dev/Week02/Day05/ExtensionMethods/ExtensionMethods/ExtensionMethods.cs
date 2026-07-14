using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {

        public static string ToTitleCase(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            return textInfo.ToTitleCase(text.ToLower());
        }

        public static bool IsNullOrEmpty<T>(this List<T> list)
        {
            return list == null || list.Count == 0;
        }

        public static string ToWords(this int number)
        {
            if (number < 0 || number > 999)
                throw new ArgumentOutOfRangeException(
                    "Only numbers between 0 and 999 are supported.");

            if (number == 0)
                return "Zero";

            string[] ones =
            {
                "", "One", "Two", "Three", "Four",
                "Five", "Six", "Seven", "Eight", "Nine",
                "Ten", "Eleven", "Twelve", "Thirteen",
                "Fourteen", "Fifteen", "Sixteen",
                "Seventeen", "Eighteen", "Nineteen"
            };

            string[] tens =
            {
                "", "", "Twenty", "Thirty", "Forty",
                "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
            };

            string words = "";

            // Hundreds
            if (number >= 100)
            {
                words += ones[number / 100] + " Hundred";

                number %= 100;

                if (number > 0)
                    words += " ";
            }

            // 1 - 19
            if (number < 20)
            {
                words += ones[number];
            }
            else
            {
                words += tens[number / 10];

                if (number % 10 > 0)
                {
                    words += " " + ones[number % 10];
                }
            }

            return words.Trim();
        }
    }
}