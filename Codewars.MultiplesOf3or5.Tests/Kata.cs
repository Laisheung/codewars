using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars.MultiplesOf3or5.Tests
{
    internal class Kata
    {   
        //return Enumerable.Range(0, number).Sum(currentNumber =>
            //{
            //    int divBy3 = currentNumber % 3;
            //    int divBy5 = currentNumber % 5;

            //    if (divBy3 == 0 && divBy5 == 0) return currentNumber;
            //    else if (divBy3 == 0 || divBy5 == 0) return currentNumber;
            //    else return 0;
            //});
        
        internal static int Solution(int number)
        {
            var sum = 0;
            for (int currentNumber = 0; currentNumber < number; currentNumber++)
            {
                switch (currentNumber % 3)
                {
                    case 0 when currentNumber % 5 == 0:
                        sum += currentNumber;
                        break;
                    default:
                        if (currentNumber % 3 == 0 || currentNumber % 5 == 0)
                        {
                            sum += currentNumber;
                        }
                        break;
                }
            }

            return sum;
        }
    }
}