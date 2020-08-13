using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            foreach (string a in words)
            {
                if (a == null)
                {
                    return false;
                }
            }
            if (ignoreCase == true)
            {
                foreach (string a in words)
                {
                    if (a.ToUpper() == word.ToUpper())
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (string a in words)
                {
                    if (a == word)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            if (num < 0)
            {
                return false;
            }
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0 && i != 1)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = 1001;
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                counter = 0;
                foreach (char a in str)
                {
                    if (str[i] == a)
                    {
                        counter++;
                    }
                }
                if (counter < 2)
                {
                    index = i;
                }
            }
            if (index == 1001)
            {
                return -1;
            }
            return index;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int counter = 0;
            int maxCC = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                counter = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                    else if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                }
                if (counter > maxCC)
                {
                    maxCC = counter;
                }
            }
            return maxCC;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> list = new List<double>();
            int x = n;

            if (elements == null)
                return list.ToArray();

            for (int i = 0; i < elements.Count(); i++)
            {
                if (elements[i] == x)
                {
                    list.Add(elements[i]);
                    x += n;
                }
            }
            return list.ToArray();
        }

    }

}
