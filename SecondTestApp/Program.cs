using System;

class hoRRiblEcoDe
{
    static void Main()
    {
        {
            int a = 1;
           for(int i = 2; i < 1000; i++)
            {
                a += 1;
                if (a % 2 == 0)
                {
                    Console.WriteLine(-a);
                }
                else
                    Console.WriteLine(a);
            }

        }
    }
}