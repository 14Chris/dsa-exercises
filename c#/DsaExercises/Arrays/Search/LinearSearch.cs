namespace Arrays.Search;

public static class LinearSearch
{
    public static int Search(int[] arrayToSearch, int valueToSearch)
    {
        for(int i = 0; i < arrayToSearch.Length; i++)
        {
            if(arrayToSearch[i] == valueToSearch)
            {
                return i;
            }
        }

        return -1;
    }
}