namespace Arrays;

public static class BubbleSort
{
    public static int[] Sort(int[] arrayToSort)
    {
        for (int i = 0; i < arrayToSort.Length - 1; i++)
        {
            var swapped = false;
            
            for (int j = 0; j < arrayToSort.Length -1 - i; j++)
            {
                if (arrayToSort[j] > arrayToSort[j + 1])
                {
                    int temp = arrayToSort[j];
                    arrayToSort[j] = arrayToSort[j + 1];
                    arrayToSort[j + 1] = temp;
                    
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }

        return arrayToSort;
    }
}