namespace ReverseWordsInAStringIII;

public class Solution
{
  public static string ReverseWords(string s)
  {
    string[] words = s.Split();
    List<string> reversed = [];

    foreach (string word in words)
    {
      char[] chars = word.ToCharArray();
      Array.Reverse(chars);
      reversed.Add(new string(chars));
    }

    return string.Join(' ', [.. reversed]);
  }

  public static void Test()
  {
    Console.WriteLine(ReverseWords("Let's take LeetCode contest"));
    // s'teL ekat edoCteeL tsetnoc
    Console.WriteLine(ReverseWords("Mr Ding"));
    // rM gniD
  }
}


/*

Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

Example 1:

Input: s = "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"

Example 2:

Input: s = "Mr Ding"
Output: "rM gniD"

*/
