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

            foreach (int prime in s.GetPrimes())
                Console.WriteLine(prime);
        }
    }
}
