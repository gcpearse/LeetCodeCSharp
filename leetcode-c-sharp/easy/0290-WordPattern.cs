namespace WordPattern;

public class Solution
{
  public static bool WordPattern(string pattern, string s)
  {
    Dictionary<char, string> map = [];

    string[] words = s.Split(' ');

    if (pattern.Length != words.Length) return false;

    for (int i = 0; i < pattern.Length; i++)
    {
      if (!map.TryGetValue(pattern[i], out string? value))
      {
        if (!map.ContainsValue(words[i]))
        {
          map.Add(pattern[i], words[i]);
        }
        else
        {
          return false;
        }
      }
      else if (value != words[i]) return false;
    }

    return true;
  }
}


/*

Given a pattern and a string s, find if s follows the same pattern.

Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.

Example 1:

Input: pattern = "abba", s = "dog cat cat dog"
Output: true

Example 2:

Input: pattern = "abba", s = "dog cat cat fish"
Output: false

Example 3:

Input: pattern = "aaaa", s = "dog cat cat dog"
Output: false

*/
