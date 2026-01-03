/*
    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
*/

Solution solution = new Solution();
Console.WriteLine(solution.GetRomanToInt("I")); // 1
Console.WriteLine(solution.GetRomanToInt("II")); // 2
Console.WriteLine(solution.GetRomanToInt("V")); // 5
Console.WriteLine(solution.GetRomanToInt("IV")); // 4
Console.WriteLine(solution.GetRomanToInt("X")); // 10
Console.WriteLine(solution.GetRomanToInt("IX")); // 9

public class Solution
{
    public int GetRomanToInt(string romanNumber)
    {
        Dictionary<char, int> romanToInteger = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
        int sum = 0;
        int i = romanNumber.Length - 1;

        while(i >= 0)
        {
            if (i > 0 &&  romanToInteger[romanNumber[i-1]] < romanToInteger[romanNumber[i]])
            {
                sum += romanToInteger[romanNumber[i]] - romanToInteger[romanNumber[i - 1]];
                i -= 2;
            }
            else
            {
                sum += romanToInteger[romanNumber[i]];
                i--;
            }
        }

        return sum;
    }
}