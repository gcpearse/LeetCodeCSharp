namespace LongestCommonPrefix;

public class Solution
{
  public static string LongestCommonPrefix(string[] strs)
  {
    string commonPrefix = "";
    int index = 0;

    while (strs.All(str => str.Length > index))
    {
      if (strs.All(str => str[index] == strs[0][index]))
      {
        commonPrefix += strs[0][index];
        index++;
      }
      else
      {
        break;
      }
    }

    return commonPrefix;
  }

  public static void Test()
  {
    Console.WriteLine(LongestCommonPrefix([
      "flower",
      "flow",
      "flight"
    ]));
    // "fl"
    Console.WriteLine(LongestCommonPrefix([
      "dog",
      "racecar",
      "car"
    ]));
    // ""
  }
}


/* 

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower", "flow", "flight"]
Output: "fl"

Example 2:

Input: strs = ["dog", "racecar", "car"]
Output: ""
Explanation: There is no common prefix among the input strings.

*/
