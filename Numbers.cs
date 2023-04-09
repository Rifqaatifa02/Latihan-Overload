using System;
using Internal;

namespace Overload
{
    public class Numbers
    {
        public int cariNilaiMin(int a, int b)
        {
            int min = 0;
            if (a < b)
            {
                Console.WriteLine("Nilai minimum dari kedua nilai adalah = {0}", min = a);
                Console.ReadKey();
            }
            else if (b < a)
            {
                Console.WriteLine("Nilai minimum dari kedua nilai adalah = {0}", min = b);
                Console.ReadKey();
            }

            return min;
        }
        public int cariNilaiMax(int a, int b)
        {
            int max = 0;
            if (a > b)
            {
                Console.WriteLine("Nilai maksimum dari kedua nilai adalah = {0}", max = a);
                Console.ReadKey();
            }
            else if (b > a)
            {
                Console.WriteLine("Nilai maksimum dari kedua nilai adalah = {0}", max = b);
                Console.ReadKey();
            }

            return max;
        }
    }
}

