

// Bubble Sort Algorithm
// Time Complexity: O(n^2)

int[] arr = [10, 20, 4, 1, 7, 3, 11, 2, 17, 9, 5, 19];

var length = arr.Length;

for (var i = 0; i < length - 1; i++)
{
    for (var j = 0; j < length - i - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            // we could swap using tuple deconstruction
            // (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
            // or 
            // Swap using a temporary variable
            Console.WriteLine($"Swapping {arr[j]} and {arr[j + 1]}");
            var temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
}


var sorted = string.Join(" , ", arr);
Console.WriteLine($"Sorted array: {sorted}");

// ✅ With Swap Flag:
// We stop the loop as soon as we detect that no swaps happened — which means the array is already sorted.

for (var i = 0; i < length - 1; i++)
{
    bool isSwapHappened = false;

    for (var j = 0; j < length - i - 1; j++)
    {
        if (arr[j] > arr[j + 1])
        {
            // we could swap using tuple deconstruction
            // (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
            // or 
            // Swap using a temporary variable
            Console.WriteLine($"Swapping {arr[j]} and {arr[j + 1]}");
            var temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;

            isSwapHappened = true; // a swap happened, so the array is not sorted yet
        }

        if (!isSwapHappened)
        {
            // array is already sorted. no need to continue
            break;
        }
    }
}



