using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public static class MathHelpers3
    {

        public static List<int> GetPowersOf2(int num)
        {
            List<int> powers = new List<int>();
            double squared;
            for (int i = 0; i <= num; i++)
            {
                squared = Math.Pow(2, i);
                powers.Add((int)squared);
            }
            return powers;
        }
    }
}
