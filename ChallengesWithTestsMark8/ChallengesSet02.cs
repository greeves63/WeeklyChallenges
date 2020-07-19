using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphaBet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (alphaBet.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if  (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() <= 0)
            {
                return 0;
            }
            double num1 = numbers.Min();
            double num2 = numbers.Max();
            var sumOfNumbers = num1 + num2;

            return sumOfNumbers;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var shortestString = (str1.Length > str2.Length) ? str2.Length : str1.Length;
            return shortestString;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            else
            {
                int totalSum = 0;
                foreach(int x in numbers)
                {
                    if (x % 2 == 0)
                    {
                        totalSum += x;
                    }
                }return totalSum;
                        
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int totalSumOdd = 0;
            foreach(int x in numbers)
            {
                totalSumOdd += x;
            }
            if (totalSumOdd % 2 == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number > 0)
            {
                return number / 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
