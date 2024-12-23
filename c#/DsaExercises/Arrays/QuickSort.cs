using System.Collections.Concurrent;

namespace Arrays;

public static class QuickSort
{
    public static int[] Sort(int[] arrayToSort, int start, int end)
    {
        if (start < end)
        {
            var partitionIndex = Partition(arrayToSort, start, end);
            Sort(arrayToSort, start, partitionIndex - 1);
            Sort(arrayToSort, partitionIndex + 1, end);
        }
        
        return arrayToSort;
    }
    
    private static void Swap(int[] arr, int i, int j) 
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    private static int Partition(int[] arrayToSort, int start, int end)
    {
        var pivot = arrayToSort[end];

        var i = start - 1;

        for (int j = start; j < end; j++)
        {
            if (arrayToSort[j] < pivot)
            {
                i++;
                Swap(arrayToSort, i, j);
            }
        }
        
        Swap(arrayToSort, i+1, end);
        return i + 1;
    }
}