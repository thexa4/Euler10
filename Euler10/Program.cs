using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler10
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 2000000;
            var s = new Sieve(size);

            long count = 0;

            foreach (int prime in s.GetPrimes())
                count += prime;

            Console.Write(count);

            Console.ReadLine();
        }
    }
}
