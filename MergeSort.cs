namespace Sorting_Algorithms;

public class MergeSort
{
    public static int[] MergeSorter(int[] array)
    {
        if (array.Length <= 1)
            return array;

        int mid = array.Length / 2;

        int[] left = array.Take(mid).ToArray();
        int[] right = array.Skip(mid).ToArray();

        return Merge(MergeSorter(left), MergeSorter(right));
    }


    private static int[] Merge(int[] left, int[] right)
    {
        List<int> result = [];
        int i = 0, j = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] < right[j])
            {
                result.Add(left[i]);
                i++;
            }
            else
            {
                result.Add(right[j]);
                j++;
            }
        }

        while (i < left.Length) result.Add(left[i++]);
        while (j < right.Length) result.Add(right[j++]);

        return [.. result];
    }
}