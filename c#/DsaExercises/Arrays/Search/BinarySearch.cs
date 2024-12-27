namespace Arrays.Search;

public static class BinarySearch
{
    public static int Search(int[] arrayToSearch, int valueToSearch)
    {
        var minIndex = 0;
        var maxIndex = arrayToSearch.Length - 1;

        while (minIndex <= maxIndex)
        {
            var midIndex = (maxIndex + minIndex) / 2;
            
            if (arrayToSearch[midIndex] == valueToSearch)
            {
                return midIndex;
            }

            if (arrayToSearch[midIndex] > valueToSearch)
            {
                maxIndex = midIndex - 1;
            }
            else
            {
                minIndex = midIndex + 1;
            }
        }
        
        return -1;
    }
}