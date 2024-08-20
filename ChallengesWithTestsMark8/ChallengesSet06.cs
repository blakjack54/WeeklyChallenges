using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || string.IsNullOrEmpty(word))
            {
                return false;
            }

            if (ignoreCase)
            {
                word = word.ToLower();
                foreach (var w in words)
                {
                    if (w != null && w.ToLower() == word)
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (var w in words)
                {
                    if (w == word)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str.LastIndexOf(str[i]) == str.IndexOf(str[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }

            return Math.Max(maxCount, currentCount);
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0 || n > elements.Count)
            {
                return new double[0];
            }

            var nthElements = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                nthElements.Add(elements[i]);
            }

            return nthElements.ToArray();
        }
    }
}
