using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pow = new List<int>();

            pow = MathHelpers3.GetPowersOf2(4);

            foreach (int p in pow)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}
