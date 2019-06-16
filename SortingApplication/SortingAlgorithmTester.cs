using System;
using SortingApplication.Logger;
using SortingApplication.Sorting;

namespace SortingApplication
{
    class SortingAlgorithmTester
    {
        public ConsoleLogger Logger { get; set; } = new ConsoleLogger();
        public GetEnumValues GetEnumValues { get; set; } = new GetEnumValues();
        public GetArray GetArray { get; set; } = new GetArray();
        
        private int TestSortings(SortingAlgorithm algorithm, int[] array)
        {
            var sorter = SorterFactory.GetSorter();
            var swapped = sorter.Sort(algorithm, array);

            return swapped;
        }

        public void Test()
        {
            var values = GetEnumValues.Values();
            foreach (var algorithm in values)
            {
                int[] array = GetArray.Array();
                var swapped = TestSortings(algorithm, array);
                Logger.Log($"sorting done using {algorithm}, needed {swapped} swaps to sort the array");
            }

            Console.ReadKey();
        }
    }
}
