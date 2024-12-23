using Arrays;

int[] array = [7, 12, 9, 11, 3];

var sortedArray = InsertionSort.Sort(array);

Console.WriteLine("Array [{0}]", string.Join(", ", array));
Console.WriteLine("Sorted array : [{0}]", string.Join(", ", sortedArray));