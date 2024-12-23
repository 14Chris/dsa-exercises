namespace Arrays;

public static class InsertionSort
{
    public static int[] Sort(int[] arrayToSort)
    {
        for (int i = 0; i < arrayToSort.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                // Swap if the element at j - 1 position is greater than the element at j position
                if (arrayToSort[j - 1] > arrayToSort[j])
                {
                    (arrayToSort[j - 1], arrayToSort[j]) = (arrayToSort[j], arrayToSort[j - 1]);
                }
            }
        }
        return arrayToSort; // Return the sorted array
    }
}