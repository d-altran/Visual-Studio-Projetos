using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Calculator
    {
       /* public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        } */

        public static void Triple(ref int x)
        {
            x = x * 3;
            Console.WriteLine(x);
        }

        public static void Triple1(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
