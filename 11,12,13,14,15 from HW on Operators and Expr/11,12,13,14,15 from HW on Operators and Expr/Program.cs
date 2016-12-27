using System;

namespace _11_12_13_14_15_from_HW_on_Operators_and_Expr
{
    class thirdBit
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int p = 3;

            int nRightP = a >> p;
            int bit = nRightP & 1;

            Console.WriteLine(bit);
            Console.WriteLine(nRightP);
        }
    }
}
