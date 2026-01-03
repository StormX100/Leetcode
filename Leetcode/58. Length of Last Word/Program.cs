/*Given a string s consisting of words and spaces, return the length of the last word in the string.

 A word is a maximal consisting of non-space characters only.
*/

Solution solution = new Solution();
Console.WriteLine(solution.GetLengthOfLastWord("luffy is still joyboy")); //6
Console.WriteLine(solution.GetLengthOfLastWord("   fly me   to   the moon  ")); //4


public class Solution
{
    public int GetLengthOfLastWord(string text)
    {
        return text.Trim().Split(" ").Last().Length;
    }
}