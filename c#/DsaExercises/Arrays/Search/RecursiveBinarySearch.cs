namespace Arrays.Search;

public static class RecursiveBinarySearch
{
    public static int Search(int[] arrayToSearch, int valueToSearch, int min, int max)
    {
        if (min > max)
        {
            return -1;
        }

        var mid = (min + max) / 2;

        if (arrayToSearch[mid] == valueToSearch)
        {
            return mid;
        }

        if (arrayToSearch[mid] > valueToSearch)
        {
            return Search(arrayToSearch, valueToSearch, min, mid - 1);
        }

        return Search(arrayToSearch, valueToSearch, mid + 1, max);
    }
}