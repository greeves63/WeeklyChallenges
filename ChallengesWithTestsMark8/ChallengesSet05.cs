using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while (startNumber % n != 0)
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool answer = true;

            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] <= numbers[i + 1])
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                    break;
                }
            }
            return answer;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var sumElements = 0;
            for (int x = 0; x < numbers.Length - 1; x++)
            {
                if (numbers[x] % 2 == 0)
                {
                    sumElements += numbers[x + 1];
                }
            }
            return sumElements;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
            {
                return "";
            }
            else if (words.Length == 0)
            {
                return "";
            }

            var trimmed = new List<string>();
            foreach(var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    trimmed.Add(word.Trim());
                }
            }
            var sentence = string.Join(" ", trimmed);
            if (string.IsNullOrWhiteSpace(sentence))
            {
                return "";
            }
            else
            {
                return sentence + ".";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {
                return new double[] { };
            }
            var list = new List<double>();
            for (int i = 3; i < elements.Count(); i+= 4)
            {
                list.Add(elements[i]);
            }
            return list.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            var counter = 0;

            for (int x = 0; x < nums.Length; x++)
            {
                for (int y = 1; y < nums.Length; y++)
                {
                    if (x != y)
                    {
                        if (nums[x] + nums[y] == targetNumber)
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter != 0;
        }
    }
}
