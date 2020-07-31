using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evenNumbers = 0;
            var oddNumbers = 0;

            foreach(var x in numbers)
            {
                if (x % 2 == 0)
                {
                    evenNumbers += x;
                }
                else if (x % 2 != 0)
                {
                    oddNumbers += x;
                }
            }
            return evenNumbers - oddNumbers;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringOne = str1.Length;
            var stringTwo = str2.Length;
            var stringThree = str3.Length;
            var stringFour = str4.Length;

            if (stringOne < stringTwo && stringOne < stringThree && stringOne < stringFour)
            {
                return stringOne;
            }
            else if (stringTwo <= stringOne && stringTwo < stringThree && stringTwo < stringFour)
            {
                return stringTwo;
            }
            else if (stringThree <= stringOne && stringThree <= stringTwo && stringThree < stringFour)
            {
                return stringThree;
            }
            else
            {
                return stringFour;
            }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numberOne = number1;
            var numberTwo = number2;
            var numberThree = number3;
            var numberFour = number4;

            if (numberOne < numberTwo && numberOne < numberThree && numberOne < numberFour)
            {
                return numberOne;
            }
            else if (numberTwo <= numberOne && numberTwo < numberThree && numberTwo < numberFour)
            {
                return numberTwo;
            }
            else if (numberThree <= numberOne && numberThree <= numberTwo && numberThree < numberFour)
            {
                return numberThree;
            }
            else
            {
                return numberFour;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var list = new List<int> { sideLength1, sideLength2, sideLength3 };
            list.Sort();
            return list[0] + list[1] > list[2];
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }
            if (input.Length < 1)
            {
                return false;
            }

            int count = 0;

            foreach(var i in input)
            {
                if (char.IsDigit(i))
                {
                    count++;
                }
                else if (char.IsLetter(i))
                {
                    count += 0;
                }
                else if (char.IsSymbol(i))
                {
                    count += 0;
                }
                else if (i == '.')
                {
                    count ++;
                }
                else if (i == '-')
                {
                    count++;
                }
                
            }
            if (count == input.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var counter = 0;
            foreach (var o in objs)
            {
                if (o == null)
                {
                    counter++;
                }
            }
            if (counter > objs.Length / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || (numbers.Length == 0))
            {
                return 0;
            }
          
            if (numbers.Where(x => x % 2 == 0).Count() > 0)
            {
                return numbers.Where(x => x % 2 == 0).Average();
            }
            return 0;
        }

        public int Factorial(int number)
        {

            if (number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number");
            }

            int facts = number;
            for (int i = number - 1; i >= 1; i--)
            {
                facts *= i;
            }
            return facts;
        }

    }
}
