namespace LeetCodeCSharp.Easy;

public class ValidAnagramSolution
{
  public static bool IsAnagram(string s, string t)
  {
    if (s.Length != t.Length) return false;

    char[] sChars = s.ToCharArray();
    char[] tChars = t.ToCharArray();

    Array.Sort(sChars);
    Array.Sort(tChars);

    return new string(sChars) == new string(tChars);
  }
}


/*

Given two strings s and t, return true if t is an anagram of s, and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

Example 1:

Input: s = "anagram", t = "nagaram"
Output: true

Example 2:

Input: s = "rat", t = "car"
Output: false

*/
