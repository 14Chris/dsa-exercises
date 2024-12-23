namespace Arrays;

public class QuickSort
{
    public static int[] Sort(int[] arrayToSort, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = arrayToSort[leftIndex];
        
        Console.WriteLine("Array [{0}]", string.Join(", ", arrayToSort));
        
        while (i <= j)
        {
            while (arrayToSort[i] < pivot)
            {
                i++;
            }
        
            while (arrayToSort[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                int temp = arrayToSort[i];
                arrayToSort[i] = arrayToSort[j];
                arrayToSort[j] = temp;
                i++;
                j--;
            }
        }
    
        if (leftIndex < j)
            Sort(arrayToSort, leftIndex, j);

        if (i < rightIndex)
            Sort(arrayToSort, i, rightIndex);

        return arrayToSort;
    }
}