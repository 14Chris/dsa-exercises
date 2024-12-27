using Arrays;
using Arrays.Search;
using Arrays.Sort;

int[] array = [7, 12, 9, 11, 3, 15, 22, 1, 54, 9, 65, 19];
// Search
//
// Console.WriteLine("Array [{0}]", string.Join(", ", array));
//
var sortedArray = MergeSort.Sort(array);
//
// Console.WriteLine("Sorted array : [{0}]", string.Join(", ", sortedArray));

Console.WriteLine("Array [{0}]", string.Join(", ", sortedArray));

var value = 22;

var foundIndex = RecursiveBinarySearch.Search(sortedArray, value, 0, sortedArray.Length - 1);

Console.WriteLine("Element found at index {0}", foundIndex);
