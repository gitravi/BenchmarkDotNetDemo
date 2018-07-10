using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNetApplicaltion.Alogorithms;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;

namespace BenchmarkDotNetApplicaltion
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Driver>();
        }
    }


    //Add the parameters here
    [MinColumn, Q1Column, Q3Column, MaxColumn, MedianColumn, MeanColumn, StdErrorColumn, SkewnessColumn, StdDevColumn]
    //Add exporters here
    [MarkdownExporter, HtmlExporter, CsvExporter, MemoryDiagnoser]
    public class Driver
    {
        //Add differnt values for the key to repeat the test.
        [Params(33, 333, 555, 777, 987)]
        public int key { get; set; }
        public int arraySize { get; set; }
        public int[] input { get; set; }

        public Driver()
        {
            arraySize = 1000;
            input = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                input[i] = i;
            }
        }

        [Benchmark]
        public void LinearSearchPerformance()
        {
            int index_1 = LinearSearch.Search(input, key);
        }

        [Benchmark(Baseline = true)]
        public void BinarySearchPerformance()
        {
            int index_2 = BinarySearch.Search(key, input, 0, input.Length - 1);
        }

    }
}
