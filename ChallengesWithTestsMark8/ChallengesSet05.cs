using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int remainder = startNumber % n;
            return remainder == 0 ? startNumber + n : startNumber + (n - remainder);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
                return "";

            string sentence = string.Join(" ", words.Where(word => !string.IsNullOrWhiteSpace(word)).ToArray());
            return string.IsNullOrWhiteSpace(sentence) ? "" : sentence.Trim() + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            return elements?.Where((value, index) => (index + 1) % 4 == 0).ToArray() ?? new double[0];
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = targetNumber - num;
                if (seenNumbers.Contains(complement))
                {
                    return true;
                }
                seenNumbers.Add(num);
            }
            return false;
        }
    }
}
