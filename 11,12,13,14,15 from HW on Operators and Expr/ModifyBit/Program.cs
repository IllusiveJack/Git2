using System;

namespace ModifyBit
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            if (v == 0)
            {
                int mask = ~(1 << P);
                int result = N & mask;
                Console.WriteLine(result);
            }
            else
            {
                int mask = 1 << P;
                int result = N | mask;
                Console.WriteLine(result);
            }
        }
    }


}
