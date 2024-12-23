namespace Arrays;

public class LowestValueInArray
{
    public static void FindLowestValueInArray()
    {
        int[] array = [7, 12, 9, 4, 11];

        int lowestValue = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < lowestValue)
            {
                lowestValue = array[i];
            }
        }

        Console.WriteLine(lowestValue);
    }
}