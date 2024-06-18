namespace LeetCodeCSharp.Easy;

public class KeyboardRowSolution
{
  public static string[] FindWords(string[] words)
  {
    string[] rows = [
      "qwertyuiop",
      "asdfghjkl",
      "zxcvbnm"
    ];

    List<string> result = [];

    foreach (string word in words)
    {
      char[] chars = word.ToCharArray();
      
      foreach (string row in rows)
      {
        if (chars.All(c => row.Contains(c.ToString(), StringComparison.CurrentCultureIgnoreCase)))
        {
          result.Add(word);
        }
      }
    }

    return [.. result];
  }
}


/*

Given an array of strings words, return the words that can be typed using letters of the alphabet on only one row of American keyboard.

In the American keyboard:

the first row consists of the characters "qwertyuiop",
the second row consists of the characters "asdfghjkl", and
the third row consists of the characters "zxcvbnm".

Example 1:

Input: words = ["Hello", "Alaska", "Dad", "Peace"]
Output: ["Alaska", "Dad"]

Example 2:

Input: words = ["omk"]
Output: []

Example 3:

Input: words = ["adsdf", "sfd"]
Output: ["adsdf", "sfd"]

*/
