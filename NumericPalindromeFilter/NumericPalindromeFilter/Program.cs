using System;
using System.Collections.Generic;
using System.Linq;

namespace NumericPalindromeFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInput;
            int numberInputAsInt;
            var numbersList = new List<int>();
            var firstNumberDigits = new List<int>();
            int divisionInt = 10;




            while (numbersList.Count < 2)
            {
                {
                    Console.WriteLine("Please enter a numbers with more than five digits.");

                    numberInput = Console.ReadLine();

                    {
                        if (Int32.TryParse(numberInput, out numberInputAsInt) && numberInputAsInt.ToString().Count() > 5)
                        {
                            numbersList.Add(numberInputAsInt);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number.");
                        }
                    }
                }
            }
        }

        static bool isPalindrome(int numberInputAsInt, List<int> firstNumberDigits, int divisionInt, List<int> secondNumberDigits)
        {
            for (int i = 0; i < numberInputAsInt.ToString().Count(); i++)
            {
                firstNumberDigits.Add((numberInputAsInt / divisionInt) % 10);
                divisionInt = divisionInt * 10;
            }

            for (int i = 0; i < numberInputAsInt.ToString().Count(); i++)
            {
                secondNumberDigits.Add((numberInputAsInt / divisionInt) % 10);
                divisionInt = divisionInt * 10;
            }

            if (firstNumberDigits.Except(firstNumberDigits.Reverse()).ToList())
            {
                
            }
        }
    }
}
