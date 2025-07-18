using Sorting_Algorithms;

int[] arr = [4, 7, 19, 1, 3, 11, 17, 9, 2];

var result = MergeSort.MergeSorter(arr);

System.Console.WriteLine($"Sorted array: {string.Join(", ", result)}");
