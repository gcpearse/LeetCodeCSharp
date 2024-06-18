namespace LeetCodeCSharp.Easy;

public class LongestPalindromeSolution
{
  public static int LongestPalindrome(string s)
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

    int result = 0;
    bool hasOdds = false;

    foreach (KeyValuePair<char, int> pair in tally)
    {
      if (pair.Value % 2 == 0)
      {
        result += pair.Value;
      }
      else
      {
        hasOdds = true;
        result += pair.Value - 1;
      }
    }

    return hasOdds ? result + 1 : result;
  }
}


/*

Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.

Letters are case sensitive, for example, "Aa" is not considered a palindrome here.

Example 1:

Input: s = "abccccdd"
Output: 7
Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.

Example 2:

Input: s = "a"
Output: 1
Explanation: The longest palindrome that can be built is "a", whose length is 1.

*/
