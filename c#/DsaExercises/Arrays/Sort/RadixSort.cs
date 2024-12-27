namespace Arrays.Sort;

public static class RadixSort
{
    public static int[] Sort(int[] arrayToSort)
    {
        var radixArray = new int[9, 0];

        var maxVal = GetMaxVal(arrayToSort);

        for (int exponent = 1; maxVal / exponent > 0; exponent *= 10)
            CountingSort(arrayToSort, exponent);

        return arrayToSort;
    }

    private static int GetMaxVal(int[] arrayToSort)
    {
        int maxVal = 0;

        for (int i = 0; i < arrayToSort.Length; i++)
        {
            if (maxVal < arrayToSort[i])
            {
                maxVal = arrayToSort[i];
            }
        }

        return maxVal;
    }

    private static void CountingSort(int[] arrayToSort, int exponent)
    {
        var outputArray = new int[arrayToSort.Length];
        var occurrenceArray = new int[10];

        // Set the occurrenceArray to 0
        for (int i = 0; i < 10; i++)
        {
            occurrenceArray[i] = 0;
        }

        // Increment the occurrenceArray based on the digit at the exponent position
        for (int i = 0; i < arrayToSort.Length; i++)
        {
            occurrenceArray[(arrayToSort[i] / exponent) % 10]++;
        }

        for (int i = 1; i < 10; i++)
        {
            occurrenceArray[i] += occurrenceArray[i - 1];
        }
        
        for (int i = arrayToSort.Length - 1; i >= 0; i--)
        {
            outputArray[occurrenceArray[(arrayToSort[i] / exponent) % 10] - 1] = arrayToSort[i];
            occurrenceArray[(arrayToSort[i] / exponent) % 10]--;
        }
        
        for (int i = 0; i < arrayToSort.Length; i++)
            arrayToSort[i] = outputArray[i];
    }
}