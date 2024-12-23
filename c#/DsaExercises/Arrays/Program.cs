﻿using Arrays;

int[] array = [7, 12, 9, 11, 3, 15, 22, 1, 54, 9, 65, 19];

var sortedArray = QuickSort.Sort(array, 0, array.Length - 1);

Console.WriteLine("Array [{0}]", string.Join(", ", array));
Console.WriteLine("Sorted array : [{0}]", string.Join(", ", sortedArray));