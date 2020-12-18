using System;

namespace Codewars.RomanNumerals
{
    internal class RomanDecode
    {
        internal static double Solution(string roman)
        {
            int sum = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                var firstNumber = ToNumber(roman[i]);

                if (i + 1 < roman.Length)
                {
                    var secondNumber = ToNumber(roman[i + 1]);

                    if (firstNumber >= secondNumber)
                    {
                        sum += firstNumber;
                    }
                    else
                    {
                        sum += secondNumber - firstNumber;
                        i++;
                    }
                }
                else
                {
                    sum += firstNumber;
                }
            }

            return sum;
        }

        private static int ToNumber(char roman)
        {
            return roman switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => 0,
            };
        }
    }
}