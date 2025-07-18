namespace Sorting_Algorithms;

public class BubbleSort
{
    public static int[] Sort(int[] arr)
    {
        for (var i = 0; i < arr.Length - 1; i++)
        {
            for (var j = 0; j < arr.Length - i - 1; j++)
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

        return arr;
    }


    // ✅ With Swap Flag:
    // We stop the loop as soon as we detect that no swaps happened — which means the array is already sorted.
    public static int[] OptimizedSort(int[] arr)
    {
        for (var i = 0; i < arr.Length - 1; i++)
        {
            bool isSwapHappened = false;

            for (var j = 0; j < arr.Length - i - 1; j++)
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

        return arr;
    }
}