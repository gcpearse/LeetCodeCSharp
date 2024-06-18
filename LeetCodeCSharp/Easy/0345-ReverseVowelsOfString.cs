namespace ReverseVowelsOfString;

public class Solution
{
  public static string ReverseVowels(string s)
  {
    char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];

    List<char> reversedVowels = [];

    string result = "";

    for (int i = s.Length - 1; i >= 0; i--)
    {
      if (vowels.Contains(s[i])) reversedVowels.Add(s[i]);
    }

    int index = 0;

    foreach (char c in s)
    {
      if (!vowels.Contains(c))
      {
        result += c;
      }
      else
      {
        result += reversedVowels[index];
        index++;
      }
    }

    return result;
  }
}


/*

Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

Example 1:

Input: s = "hello"
Output: "holle"

Example 2:

Input: s = "leetcode"
Output: "leotcede"

*/
