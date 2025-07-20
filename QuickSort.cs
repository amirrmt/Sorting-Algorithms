namespace Sorting_Algorithms;

public class QuickSort
{
    public static void Sort(int[] array, int left, int right)
    {
        // sort method gets called until the input array has one element which is already sorted  
        if (left < right)
        {
            int partitionIndex = Partition(array, left, right);

            // Recursively sort elements before and after partition
            Sort(array, left, partitionIndex - 1);
            Sort(array, partitionIndex + 1, right);
        }
    }

    private static int Partition(int[] array, int left, int right)
    {
        // Choosing the rightmost element as pivot
        // This can be optimized by choosing a better pivot
        int pivot = array[right];

        // i is the index of the smaller element
        // and it starts from one position before the leftmost element
        // and the reason that it is one position before left is because 
        // we rearrange the array except the pivot which is the last element
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);

        return i + 1;
    }

    private static void Swap(int[] array, int i, int j)
    {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

