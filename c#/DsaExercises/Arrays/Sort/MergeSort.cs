namespace Arrays.Sort;

public static class MergeSort
{
    public static int[] Sort(int[] arrayToSort)
    {
        if (arrayToSort.Length <= 1)
        {
            return arrayToSort;
        }

        int middle = arrayToSort.Length / 2;
        
        var leftArray = arrayToSort[..middle];
        var rightArray = arrayToSort[middle..];

        var sortedLeftArray = Sort(leftArray);
        var sortedRightArray = Sort(rightArray);
        
        return Merge(sortedLeftArray, sortedRightArray);
    }

    private static int[] Merge(int[] leftArray, int[] rightArray)
    {
        int[] result = new int[leftArray.Length + rightArray.Length];
        
        var i = 0;
        var j = 0;
        var k = 0;
        
        while (i < leftArray.Length && j < rightArray.Length)
        {
            if (leftArray[i] <= rightArray[j])
            {
              result[k++] = leftArray[i];
              i++;
            }
            else
            {
                result[k++] = rightArray[j];
                j++;
            }
        }
        
        while (i < leftArray.Length)
        {
            result[k++] = leftArray[i++];
        }
        
        while (j < rightArray.Length)
        {
            result[k++] = rightArray[j++];
        }
        
        return result;
    }
}