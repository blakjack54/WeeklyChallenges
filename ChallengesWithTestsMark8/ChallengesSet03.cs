using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        // Check if the array contains at least one false value
        public bool ArrayContainsAFalse(bool[] vals)
        {
            // Check if any of the boolean values in the array are false
            return vals.Contains(false);
        }

        // Determine if the sum of odd numbers in the collection is odd
        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            // Check if the collection is null or empty
            if (numbers == null || !numbers.Any())
            {
                return false;
            }

            // Calculate the sum of odd numbers
            int sumOfOdds = numbers.Where(n => n % 2 != 0).Sum();

            // Return true if the sum is odd, otherwise false
            return sumOfOdds % 2 != 0;
        }

        // Check if the password contains at least one uppercase letter, one lowercase letter, and one number
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            // Check if the password is null or empty
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            // Initialize flags for uppercase, lowercase, and number
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            // Iterate through each character in the password
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }

                // If all conditions are met, return true
                if (hasUpper && hasLower && hasDigit)
                {
                    return true;
                }
            }

            // Return false if any condition is not met
            return false;
        }

        // Get the first letter of a string
        public char GetFirstLetterOfString(string val)
        {
            // Return the first character of the string
            return val[0];
        }

        // Get the last letter of a string
        public char GetLastLetterOfString(string val)
        {
            // Return the last character of the string
            return val[val.Length - 1];
        }

        // Divide two decimal numbers and handle division by zero
        public decimal Divide(decimal dividend, decimal divisor)
        {
            // Check for division by zero
            if (divisor == 0)
            {
                return 0;
            }

            // Perform the division
            return dividend / divisor;
        }

        // Subtract the first element of the array from the last element
        public int LastMinusFirst(int[] nums)
        {
            // Subtract the first element from the last element
            return nums[nums.Length - 1] - nums[0];
        }

        // Get an array of odd numbers below 100
        public int[] GetOddsBelow100()
        {
            // Use LINQ to generate an array of odd numbers below 100
            return Enumerable.Range(1, 99).Where(n => n % 2 != 0).ToArray();
        }

        // Change all elements in a string array to uppercase
        public void ChangeAllElementsToUppercase(string[] words)
        {
            // Iterate through each word in the array and convert to uppercase
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
