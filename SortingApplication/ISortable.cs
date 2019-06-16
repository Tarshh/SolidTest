namespace SortingApplication
{
    interface ISortable
    {
        int QuickSort(int[] array);
        int QuickSort(int[] array, int Left, int Right);
        int ShakerSort(int[] array);
        int BubbleSort(int[] array);
        int Sort(SortingAlgorithm algorithm, int[] array);
    }
}
