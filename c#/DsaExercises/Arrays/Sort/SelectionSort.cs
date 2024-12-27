namespace Arrays.Sort;

public static class SelectionSort
{
    public static int[] Sort(int[] arrayToSort)
    {
        for(int i = 0; i < arrayToSort.Length - 1; i++)
        {
            int minIndex = i;

            for(int j = i + 1; j < arrayToSort.Length; j++)
            {
                if(arrayToSort[j] < arrayToSort[minIndex])
                {
                    minIndex = j;
                }
            }

            (arrayToSort[minIndex], arrayToSort[i]) = (arrayToSort[i], arrayToSort[minIndex]);
        }
        
        return arrayToSort;
    }
}