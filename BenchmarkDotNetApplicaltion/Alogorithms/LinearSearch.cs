using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkDotNetApplicaltion.Alogorithms
{
    public static class LinearSearch
    {
        public static int Search(int[] input, int key)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == key)
                    return i;
            }

            return -1;
        }
    }
}
