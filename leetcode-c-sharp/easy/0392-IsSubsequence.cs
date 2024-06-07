namespace IsSubsequence;

public class Solution
{
  public static bool IsSubsequence(string s, string t)
  {
    if (s.Length == 0) return true;

    int count = s.Length;
    int index = 0;

    for (int i = 0; i < t.Length; i++)
    {
      if (t[i] == s[index])
      {
        count--;
        
        if (index + 1 < s.Length)
        {
          index++;
        }
      }
    }

    return count == 0;
  }
}


/*

Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true

Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false

*/
