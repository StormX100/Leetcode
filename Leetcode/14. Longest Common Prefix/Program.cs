/*Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".*/

LongestCommonPrefix longestPrefix = new LongestCommonPrefix();
Console.WriteLine(longestPrefix.Get(["flower", "flow", "flight"])); // fl
Console.WriteLine(longestPrefix.Get(["cir", "car"])); // c

public class LongestCommonPrefix
{
    public string Get(string[] words)
    {
        var maxNumberOfLetters = words.OrderBy(x => x.Length).First().Length;
        var prefix = string.Empty;

        for (int i = 0; i < maxNumberOfLetters; i++)
        {         
            bool isLetterEqual = true;
            char currentLetter = words[0][i];

            for (int j = 0; j < words.Length; j++)
            {
               if(words[j][i] != currentLetter)  isLetterEqual = false;
            }

            if (isLetterEqual) prefix += words[0][i];
            else return prefix;
        }

        return prefix;
    }
}