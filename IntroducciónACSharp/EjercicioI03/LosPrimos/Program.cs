using System;

namespace LosPrimos
{
    internal class Program
    {
        static void Main()
        {
            string answer = "Y";

            do
            {
                Console.WriteLine("To calculate prime numbers, enter a number.\n" +
                                  "If you wish to close the app, enter 'N'.");
                answer = Console.ReadLine();

                if (int.TryParse(answer, out int enteredNumber))
                {
                    int temp = 0;
                    for (int i = 2; i <= enteredNumber; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                                temp++;
                        }
                        if (temp <= 2)
                        {
                            Console.WriteLine("{0}", i);
                        }
                        temp = 0;
                    }

                    Console.WriteLine("\n¿Do you want to enter a new number or close the app?\n   Enter: 'Y'es - 'N'o");
                    answer = Console.ReadLine();
                }
            } while (answer == "Y");
        }
    }
}
