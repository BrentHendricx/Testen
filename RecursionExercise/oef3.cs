using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionExercise
{
    class oef3
    {
        static void Main(string[] args)
        {
            Console.Write("Number count to sum: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //We berekenen de som via de CALL STACK
            Console.WriteLine("The sum of the forst {0} natieal numbers is: {1}", n, Sum(1, n));
            Console.ReadKey();
        }
        private static int Sum(int min, int val)
        {
            if (val == min)
                return val;
            return val + Sum(min, val - 1);
        }
    }
}
