namespace Arrays.Sort;

public static class InsertionSort
{
    public static int[] Sort(int[] arrayToSort)
    {
        for (int i = 0; i < arrayToSort.Length - 1; i++)
        {
            Console.WriteLine("CurrenValue {0}", arrayToSort[i]);
            for (int j = i + 1; j > 0; j--)
            {
                // Swap if the element at j - 1 position is greater than the element at j position
                if (arrayToSort[j - 1] > arrayToSort[j])
                {
                    Console.WriteLine("Swap {0} and {1}", arrayToSort[j], arrayToSort[j - 1]);
                    (arrayToSort[j - 1], arrayToSort[j]) = (arrayToSort[j], arrayToSort[j - 1]);
                }
            }

            Console.WriteLine("Array [{0}]", string.Join(", ", arrayToSort));
        }

        return arrayToSort; // Return the sorted array
    }
}