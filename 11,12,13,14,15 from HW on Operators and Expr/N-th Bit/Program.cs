using System;

namespace N_th_Bit
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input the number N: ");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the number P: ");
            int b = int.Parse(Console.ReadLine());

            if (b < 55 && 0 <= userInput)
            {
                int bin = userInput >> b;
                int bit = bin & 1;
                Console.WriteLine(bit);

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
