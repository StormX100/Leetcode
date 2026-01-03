/*You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.*/

Solution solution = new();
Console.WriteLine(solution.CanJump(new int[] { 2, 3, 1, 1, 4 })); // True
Console.WriteLine(solution.CanJump(new int[] { 2, 5, 0, 0 }));  // True
Console.WriteLine(solution.CanJump(new int[] { 3, 2, 1, 0, 4 })); // False
Console.WriteLine(solution.CanJump(new int[] { 2, 0, 0 })); // True

class Solution
{
    public bool CanJump(int[] nums)
    {
        int reachable = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] + i > reachable) reachable = nums[i] + i;
            if (reachable == i) return i == nums.Length - 1;
        }

        return true;
    }
}