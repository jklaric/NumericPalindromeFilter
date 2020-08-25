using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

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
            bool isNumericPalindromeSecond = true;
            string palindromeResultFirst;
            string palindromeResultSecond;
            string anagramResult;






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

            if (IsPalindrome(numberInputAsInt, numbersList, firstNumberDigits, isNumericPalindrome) == true)
            {
                palindromeResultFirst = ("is");
            }
            else
            {
                palindromeResultFirst = ("isn't");
            }

            if (IsPalindromeSecond(numberInputAsInt, numbersList, secondNumberDigits, isNumericPalindromeSecond) == true)
            {
                palindromeResultSecond = ("is");
            }
            else
            {
                palindromeResultSecond = ("isn't");
            }

            if (IsAnagram(isNumericAnagram, firstNumberDigits, secondNumberDigits) == true)
            {
                anagramResult = ("are");
            }
            else
            {
                anagramResult = ("aren't");
            }

            Console.WriteLine("The first number " + palindromeResultFirst + " a palindromic number, the second number " + palindromeResultSecond + 
                              " a palindromic number. These numbers " + anagramResult + " Anagrams of each other");

        }


        static bool IsPalindrome(int numberInputAsInt, List<int> numbersList, List<int> firstNumberDigits, bool isNumericPalindrome)
        {

            while (numbersList[0] > 0)
            {
                firstNumberDigits.Add((numbersList[0] % 10));
                numbersList[0] = numbersList[0] / 10;
            }


            for (int i = 0; i < firstNumberDigits.Count; i++)
            {
                for (int j = firstNumberDigits.Count - 1; j >= 0; j--)
                {

                    if (firstNumberDigits[i] == firstNumberDigits[j])
                    {
                        isNumericPalindrome = true;
                    }
                    else
                    {
                        isNumericPalindrome = false;
                    }

                    i++;
                }
            }

            return isNumericPalindrome;
        }

        static bool IsPalindromeSecond(int numberInputAsInt, List<int> numbersList, List<int> secondNumberDigits, bool isNumericPalindromeSecond)
        {

            while (numbersList[1] > 0)
            {
                secondNumberDigits.Add((numbersList[1] % 10));
                numbersList[1] = numbersList[1] / 10;
            }

            for (int i = 0; i < secondNumberDigits.Count; i++)
            {
                for (int j = secondNumberDigits.Count - 1; j >= 0; j--)
                {
                    if (secondNumberDigits[i] == secondNumberDigits[j])
                    {
                        isNumericPalindromeSecond = true;
                    }
                    else
                    {
                        isNumericPalindromeSecond = false;
                    }

                    i++;
                }
            }

            return isNumericPalindromeSecond;
        }

        static bool IsAnagram(bool isNumericAnagram, List<int> firstNumberDigits, List<int> secondNumberDigits)
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
