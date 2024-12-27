namespace Arrays.Sort;

public static class CountingSort
{
    public static int[] Sort(int[] arrayToSort)
    {
        int maxVal = GetMaxVal(arrayToSort);
        
        int[] countingArray = new int[maxVal + 1];

        for (int i = 0; i < arrayToSort.Length; i++)
        {
            countingArray[arrayToSort[i]]++;
        }
        
        Console.WriteLine("Counting array [{0}]", string.Join(", ", countingArray));

        for (int i = 0, j = 0; i <= maxVal; i++)
        {
            while (countingArray[i] > 0)
            {
                arrayToSort[j] = i;
                j++;
                countingArray[i]--;
            }
        }
        
        return arrayToSort;
    }

    private static int GetMaxVal(int[] arrayToSort)
    {
        int maxVal = 0;

        for (int i = 0; i < arrayToSort.Length; i++)
        {
            if(maxVal < arrayToSort[i])
            {
                maxVal = arrayToSort[i];
            }
        }

        return maxVal;
    }
}