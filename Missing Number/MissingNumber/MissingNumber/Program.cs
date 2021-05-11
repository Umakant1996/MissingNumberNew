using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 8, 9, 10 };
            int miss = getMissingNo(a, 9);
            Console.Write(miss);
            Console.ReadKey();
        }
        static int getMissingNo(int[] a, int n)
        {
            int total = (n + 1) * (n + 2) / 2;

            for (int i = 0; i < n; i++)
                total -= a[i];

            return total;
        }
    }
}
