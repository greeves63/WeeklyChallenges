using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if ( numbers.Where(x => x % 2 != 0).Sum() % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var aNumber = 0;
            var aUpperLetter = 0;
            var aLowerLetter = 0;

            foreach(var c in password)
            {
                if(char.IsDigit(c))
                {
                    aNumber++;
                }
                else if (char.IsLower(c))
                {
                    aLowerLetter++;
                }
                else if (char.IsUpper(c))
                {
                    aUpperLetter++;
                }
            }

            if (aNumber >= 1 && aUpperLetter >= 1 && aLowerLetter >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var last = val.Length;
            return val[last - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            var firstNumber = nums[0];
            var lastNumber = nums[nums.Length - 1];
            return lastNumber - firstNumber;
        }

        public int[] GetOddsBelow100()
        {
            int[] oddNumber = Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray();

            return oddNumber;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
