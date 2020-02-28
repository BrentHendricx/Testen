using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionExercise
{
    class oef2
    {
        static int PrintNatural(int ctr, int stval)
        {
            // HEEL BELANGRIJK: STOPCRITERIUM
            if (ctr > 1)
            {
                return stval;
            }

            Console.Write("{0}n", ctr);
            ctr--;
        }
        static void Main(string[] args)
        {

        }
    }
}
