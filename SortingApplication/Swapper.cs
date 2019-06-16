namespace SortingApplication.Sorting
{
    public class Swapper : ISwapable
    {
        public void Swap(int index1, int index2, int[] array)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}