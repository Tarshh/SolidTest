namespace SortingApplication.Sorting
{
    public class Sorter : ISortable
    {
        private ISwapable _swapper;

        public Sorter()
        {
            _swapper = SwapperFactory.GetSwapper();
        }

        public int QuicksortSwapped = 0;

        public int QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        public int QuickSort(int[] array, int Left, int Right)
        {
            int L = Left;
            int R = Right;
            int pivotValue = array[(Left + Right) / 2];

            do
            {
                while (array[L] < pivotValue)
                {
                    L++;
                }
                while (pivotValue < array[R])
                {
                    R--;
                }

                if (L <= R)
                {
                    _swapper.Swap(L, R, array);
                    QuicksortSwapped++;
                    L++;
                    R--;
                }
            } while (L < R);

            if (Left < R)
            {
                QuickSort(array, Left, R);
            }
            if (L < Right)
            {
                QuickSort(array, L, Right);
            }

            return QuicksortSwapped;
        }

        public int ShakerSort(int[] array)
        {
            bool swapped = true;
            int swaps = 0;

            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        _swapper.Swap(i, i + 1, array);
                        swaps++;
                    }
                }

                if (!swapped) break;

                for (int i = array.Length - 2; i >= 0; --i)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        _swapper.Swap(i, i + 1, array);
                        swaps++;
                    }
                }
            }

            return swaps;
        }

        public int BubbleSort(int[] array)
        {
            bool swapped = true;
            var swaps = 0;
            
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        _swapper.Swap(i, i + 1, array);
                        swaps++;
                    }
                }
            }

            return swaps;
        }

        public int Sort(SortingAlgorithm algorithm, int[] array)
        {
            var swapped = 0;

            switch (algorithm)
            {
                case SortingAlgorithm.BubbleSort:
                    swapped = BubbleSort(array);
                    break;
                case SortingAlgorithm.ShakerSort:
                    swapped = ShakerSort(array);
                    break;
                case SortingAlgorithm.QuickSort:
                    swapped = QuickSort(array);
                    break;
            }

            return swapped;
        }
    }
}