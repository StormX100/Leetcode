/*
 Given an array nums of size n, return the majority element.
 The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
 */

MajorityElement majorityElement = new MajorityElement();
Console.WriteLine(majorityElement.Get(new int[] { 3, 2, 3 })); //3
Console.WriteLine(majorityElement.Get(new int[] { 2, 2, 1, 1, 1, 2, 2 })); //2

public class MajorityElement
{
    public int Get(int[] numbers)
    {
        var numsToNumberOfAppearance = new Dictionary<int, int>();
        int maxElement = 0, maxNumberOfAppearance = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numsToNumberOfAppearance.ContainsKey(numbers[i]))
            {
                numsToNumberOfAppearance[numbers[i]]++;
            }
            else
            {
                numsToNumberOfAppearance.Add(numbers[i], 1);
            }

            if (maxNumberOfAppearance < numsToNumberOfAppearance[numbers[i]])
            {
                maxNumberOfAppearance = numsToNumberOfAppearance[numbers[i]];
                maxElement = numbers[i];
            }
        }

        return maxElement;
    }
}