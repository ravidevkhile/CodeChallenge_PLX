using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexSystems
{
    class PlexChallengeFibonacci
    {

        public int[] fibonacciSequence(int[] signature, int n)
        {
            int[] result = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                int lastindex = 0;
                if (i < signature.Length)
                    result[i] = signature[i];
                else
                {
                    lastindex = i - signature.Length;
                    for (int j = i - 1; j >= lastindex; j--)
                    {
                        sum += result[j];
                    }
                    result[i] = sum;
                }

            }

            return result;
        }


    }
}
