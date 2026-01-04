/*
 You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
  
 Merge nums1 and nums2 into a single array sorted in non-decreasing order.

 The final sorted array should not be returned by the function, but instead be stored inside the array nums1. 
 To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
 */

MergedSortedArray mergedSortedArray = new MergedSortedArray();
mergedSortedArray.MergeWithLinq(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3); // 1 2 2 3 5 6
mergedSortedArray.MergeWithLinq(new int[] { 1 }, 1, new int[] { }, 0); // 1
mergedSortedArray.MergeWithLinq(new int[] { 0 }, 0, new int[] { 1 }, 1); // 1
mergedSortedArray.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3); // 1 2 2 3 5 6
mergedSortedArray.Merge(new int[] { 1 }, 1, new int[] { }, 0); // 1
mergedSortedArray.Merge(new int[] { 0 }, 0, new int[] { 1 }, 1); // 1

public class MergedSortedArray
{
    public void MergeWithLinq(int[] numbers1, int idxNumbers1, int[] numbers2, int idxNumbers2)
    {
        // works but it is not effiecient
        var sortedNums = numbers1.Take(idxNumbers1).Concat(numbers2.Take(idxNumbers2)).OrderBy(x => x).ToList();
        DisplayNumbers(sortedNums.ToArray());
    }

    public void Merge(int[] numbers1, int idxNumbers1, int[] numbers2, int idxNumbers2)
    {
        int idxMergedNumbers = numbers1.Length - 1;
        idxNumbers1--; idxNumbers2--;

        while (idxNumbers2 >= 0)
        {
            if (idxNumbers1 >= 0 && numbers1[idxNumbers1] > numbers2[idxNumbers2])
            {
                numbers1[idxMergedNumbers] = numbers1[idxNumbers1];
                idxNumbers1--;
            }
            else
            {
                numbers1[idxMergedNumbers] = numbers2[idxNumbers2];
                idxNumbers2--;
            }
            idxMergedNumbers--;
        }

        DisplayNumbers(numbers1);
    }

    private void DisplayNumbers(int[] numbers1)
    {
        for (int i = 0; i < numbers1.Count(); i++)
        {
            Console.Write(numbers1[i] + " ");
        }

        Console.WriteLine();
    }
}