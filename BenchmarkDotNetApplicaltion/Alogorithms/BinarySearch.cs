using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkDotNetApplicaltion.Alogorithms
{
    public static class BinarySearch
    {
        public static int Search(int key, int[] arr, int low, int high)
        {
            if (key > arr[high] || low > high || low == high)
            {
                return -1;
            }
            int mid = low + (high - low) / 2;
            if (arr[mid] == key)
            {
                return mid;
            }
            else
            {
                if (arr[mid] > key)
                {

                    return Search(key, arr, low, mid - 1);
                }
                else
                {
                    return Search(key, arr, mid + 1, high);
                }
            }
        }
    }
}
