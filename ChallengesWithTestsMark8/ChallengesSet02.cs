using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            // Check if the character is a letter
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            // Check if the number of elements in the array is even
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            // Check if the number is even
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            // Check if the number is odd
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            // Check if the collection is null or empty
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            // Return the sum of the minimum and maximum values in the collection
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            // Return the length of the shorter string
            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            // Return the sum of the array elements
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            // Return the sum of even numbers in the array
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Where(n => n % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            // Check if the sum of the list elements is odd
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            // Return the count of positive odd numbers below the given number
            if (number <= 0)
            {
                return 0;
            }
            return number / 2;
        }
    }
}
