using System;
using System.Collections.Generic;
using System.Linq;

namespace weeklyChallenges02
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            if (lowercaseAlphabet.ToLower().Contains(c) || (lowercaseAlphabet.ToUpper().Contains(c)))

            { return true;}

            else
            { return false; }
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.GetLength(0) % 2 == 0)
            { return true; }

            else
            { return false; }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            { return true; }

            else
            { return false; }
        }


        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            { return true; }
            else
            { return false; }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {return 0;}

            else if (numbers.Count() == 0)
            { return 0; }

            else
            { return numbers.Max() + numbers.Min(); }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int num1 = str1.Length;
            int num2 = str2.Length;
            if (num1 <= num2)
            { return num1; }
            else
            { return num2; }

        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            { return 0; }
            else
            { return numbers.Sum(); }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            { return 0; }
            int total = 0;
            foreach (var element in numbers)
            {
                if (element % 2 == 0)
                { total += element; }
            }
            return total;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            { return false; }
            else
            {
                int isOdd = numbers.Sum();
                if (isOdd % 2 == 0)
                { return false; }
                else
                { return true; }
            }
        }

         public long CountOfPositiveOddsBelowNumber(long number)
         {
            if (number <= 0)
            { return 0; }
            else
            {
                long divided = number / 2;
                return divided;
            }
                
            
         }
}   }
