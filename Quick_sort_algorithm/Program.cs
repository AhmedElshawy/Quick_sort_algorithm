namespace Quick_sort_algorithm
{
    public class Program
    {
        static void Swap(int[] arr , int x, int y)
        {
            int temp;
            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        //static int Partitioning(int[] arr, int left, int right)
        //{
        //    int start = left;
        //    int end = right;
        //    int pivotIndex = start;

        //    while (start < end)
        //    {
        //        if (arr[pivotIndex] > arr[end])
        //        {
        //            Swap(arr, start, end);
        //            start++;
        //            pivotIndex = end;
        //        }
        //        else
        //        {
        //            end--;
        //            pivotIndex = start;
        //        }
        //    }
        //    return pivotIndex;
        //}

        static int Partitioning(int[] arr, int left, int right)
        {
            int start = left;
            int end = right;
            int pivotIndex = start;

            while (true)
            {
                while (arr[pivotIndex] <= arr[end] && pivotIndex != end)
                {
                    end--;
                }
                if (pivotIndex == end)
                    break;
                else if (arr[pivotIndex] > arr[end])
                {
                    Swap(arr, pivotIndex, end);
                    pivotIndex = end;
                }

                while (arr[pivotIndex] >= arr[start] && pivotIndex != start)
                {
                    start++;
                }

                if (pivotIndex == start)
                    break;
                else if (arr[pivotIndex] < arr[start])
                {
                    Swap(arr, pivotIndex, start);
                    pivotIndex = start;
                }
            }
            return pivotIndex;
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int pivotIndex = Partitioning(arr, left, right);
                QuickSort(arr, left, pivotIndex);
                QuickSort(arr, pivotIndex+1, right);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 2, 1, 8, 9 };
            QuickSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}