namespace Arrays;

public static class InsertionSort
{
    public static int[] Sort(int[] arrayToSort)
    {
        for(int i = 0; i < arrayToSort.Length; i++)
        {
            int currentValue = arrayToSort[i];
            var toContinue = true;

            for (int j = i - 1; j >= 0 && toContinue;)
            {
                if (arrayToSort[j] > currentValue)
                {
                    arrayToSort[j + 1] = arrayToSort[j];
                    j--;
                    arrayToSort[j + 1] = currentValue;
                }
                else
                {
                    toContinue = false;
                }
            }
        }

        return arrayToSort;
    }
}