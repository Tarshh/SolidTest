namespace SortingApplication.Sorting
{
    public static class SorterFactory
    {
        public static Sorter GetSorter()
        {
            return new Sorter();
        }
    }
}