using System;

namespace UnNumeroPerfecto
{
    internal class Program
    {
        static void Main()
        {
            /*
            *To do this exercise, I won´t use the optimal algorythm.
            *This is due to the ask of the first 4 perfect numbers
            *is coincident with the fact that, the first 4 perfect numbers
            *discovered and published have been proposed by Euclid in his
            *highly-influential book "Elements" (c.300 bC). I wish to use a similar
            *system to the proposed by this genius as a homage.
            */

            int temp = 1;
            int addition = 0;
            int aux = 0;
            byte count = 0;

            for (int i = 1; count < 4; i *= 2)
            {
                temp = i;
                addition += i;
                for (int lastNumber = 2; lastNumber < addition; lastNumber++)
                {
                    if (addition % lastNumber == 0)
                    {
                        aux++;
                    }
                }
                if (aux == 0 && i != 1)
                {
                    int perfectNumber = temp * addition;
                    Console.WriteLine("Perfect number: " + perfectNumber);
                    count++;
                }
                aux = 0;
            }
        }
    }
}
