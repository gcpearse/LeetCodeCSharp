namespace FirstUniqueCharacterInString;

public class Solution
{
  public static int FirstUniqChar(string s)
  {
    Dictionary<char, int> tally = [];

    foreach (char c in s)
    {
      if (!tally.TryGetValue(c, out int value))
      {
        tally.Add(c, 1);
      }
      else
      {
        tally[c] = ++value;
      }
    }

    foreach (KeyValuePair<char, int> pair in tally)
    {
      if (pair.Value == 1) return s.IndexOf(pair.Key);
    }

    return - 1;
  }

  public static void Test()
  {
    Console.WriteLine(FirstUniqChar("leetcode"));
    // 0
    Console.WriteLine(FirstUniqChar("loveleetcode"));
    // 2
    Console.WriteLine(FirstUniqChar("aabb"));
    // -1
  }
}


/*

Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

Example 1:

Input: s = "leetcode"
Output: 0

Example 2:

Input: s = "loveleetcode"
Output: 2

Example 3:

Input: s = "aabb"
Output: -1

*/
