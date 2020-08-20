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
            int numberInputAsInt = 0;
            var numbersList = new List<int>();
            var firstNumberDigits = new List<int>();
            var secondNumberDigits = new List<int>();
            bool isNumericPalindrome = true;
            bool isNumericAnagram = true;
            





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

            if (IsPalindrome(numberInputAsInt, numbersList, firstNumberDigits, secondNumberDigits, isNumericPalindrome) == true && IsAnagram(isNumericAnagram, firstNumberDigits, secondNumberDigits) == true)
            {
                Console.WriteLine("These numbers are both palindromes and anagrams of each other.");
            }
            else if (IsPalindrome(numberInputAsInt, numbersList, firstNumberDigits, secondNumberDigits, isNumericPalindrome) == true && IsAnagram(isNumericAnagram, firstNumberDigits, secondNumberDigits) == false)
            {
                Console.WriteLine("These numbers are palindromes, but are not anagrams of each other.");
            }
            else if (IsPalindrome(numberInputAsInt, numbersList, firstNumberDigits, secondNumberDigits, isNumericPalindrome) == false && IsAnagram(isNumericAnagram, firstNumberDigits, secondNumberDigits) == true)
            {
                Console.WriteLine("These numbers are not palindromes, but are anagrams of each other.");
            }
            else if(IsPalindrome(numberInputAsInt, numbersList, firstNumberDigits, secondNumberDigits, isNumericPalindrome) == false && IsAnagram(isNumericAnagram, firstNumberDigits, secondNumberDigits) == false)
            {
                Console.WriteLine("These numbers are nor palindromes nor anagrams of each others");
            }
        }


        static bool IsPalindrome(int numberInputAsInt, List<int> numbersList, List<int> firstNumberDigits, List<int> secondNumberDigits, bool isNumericPalindrome)
        {
            int counter = 0;
            int divisionInt = 10;


            while (numbersList[0] > 0)
            {
                firstNumberDigits.Add((numbersList[0] % 10));
                numbersList[0] = numbersList[0] / 10;
                divisionInt = divisionInt * 10;
            }

            divisionInt = 10;

            while (numbersList[1] > 0)
            {
                firstNumberDigits.Add((numbersList[1] % 10));
                numbersList[1] = numbersList[1] / 10;
                divisionInt = divisionInt * 10;
            }

            var firstNumberDigitsReversed = firstNumberDigits;
            firstNumberDigitsReversed.Reverse();

            var secondNumberDigitsReversed = secondNumberDigits;
            secondNumberDigitsReversed.Reverse();

            if (firstNumberDigits[counter++] == firstNumberDigitsReversed[counter++] && secondNumberDigits[counter++] == secondNumberDigitsReversed[counter++])
            {
                isNumericPalindrome = true;
            }
            else
            {
                isNumericPalindrome = false;
            }

            return isNumericPalindrome;
        }

        static bool IsAnagram(bool isNumericAnagram, List<int> firstNumberDigits, List<int>secondNumberDigits)
        {
            if (!firstNumberDigits.Except(secondNumberDigits).Any())
            {
                isNumericAnagram = true;
            }
            else
            {
                isNumericAnagram = false;
            }

            return isNumericAnagram;
        }

    }
}
