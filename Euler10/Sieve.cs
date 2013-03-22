using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler10
{
    class Sieve
    {
        public int Size { get; protected set; }
        protected bool[] Primes { get; set; }

        public Sieve(int maxprime)
        {
            Size = maxprime;
            Primes = new bool[maxprime + 1];
            Primes[1] = true; //1 is not a prime
        }

        public IEnumerable<int> GetPrimes()
        {
            int curreturn = 1;
            int maxsieve = (int)Math.Sqrt(Size) + 1;

            // Mark all multiples of 2 as nonprime
            for (int j = 2 * 2; j <= Size; j += 2)
                Primes[j] = true;
            yield return 2;

            // We only need to do this for the sqrt of the size
            for (int i = 3; i <= maxsieve; i += 2)
            {
                // If this number is prime, all numbers that are a multiple of this one
                // are not prime
                if (Primes[i] == false)
                    for (int j = 2 * i; j <= Size; j += i)
                        Primes[j] = true;

                // Return all numbers we know to be prime for certain
                int maxreturn = i * i;
                for (; curreturn <= maxreturn && curreturn <= Size; curreturn++)
                    if (Primes[curreturn] == false)
                        yield return curreturn;
            }
        }
    }
}
