namespace FindFirstOccurrence;

public class Solution
{
  public static int StrStr(string haystack, string needle)
  {
    return haystack.IndexOf(needle);
  }

  public static void Test()
  {
    Console.WriteLine(StrStr("sadbutsad", "sad"));
    // 0
    Console.WriteLine(StrStr("leetcode", "leeto"));
    // -1
  }
}


/*

Given two strings, needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.

Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.

*/
