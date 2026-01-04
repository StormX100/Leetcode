/*Given a string s consisting of words and spaces, return the length of the last word in the string.

 A word is a maximal consisting of non-space characters only.
*/

LenthOfLastWord lengthOfLastWord = new LenthOfLastWord();
Console.WriteLine(lengthOfLastWord.Get("luffy is still joyboy")); //6
Console.WriteLine(lengthOfLastWord.Get("   fly me   to   the moon  ")); //4


public class LenthOfLastWord
{
    public int Get(string text)
    {
        return text.Trim().Split(" ").Last().Length;
    }
}