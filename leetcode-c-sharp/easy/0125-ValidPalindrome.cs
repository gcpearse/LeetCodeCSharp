namespace ValidPalindrome;

public class Solution
{
  public static bool IsPalindrome(string s)
  {
    int left = 0;
    int right = s.Length - 1;

    while (left <= right)
    {
      if (!char.IsLetterOrDigit(s[left]))
      {
        left++;
      }
      else if (!char.IsLetterOrDigit(s[right]))
      {
        right--;
      }
      else
      {
        if (char.ToLower(s[left]) != char.ToLower(s[right]))
        {
          return false;
        }
        left++;
        right--;
      }
    }

    return true;
  }

  public static void Test()
  {
    Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
    // True
    Console.WriteLine(IsPalindrome("race a car"));
    // False
    Console.WriteLine(IsPalindrome(" "));
    // True
    Console.WriteLine(IsPalindrome(".,"));
    // True
    Console.WriteLine(IsPalindrome("aa"));
    // True
  }
}


/*

A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. 
Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.

Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.

Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.

*/
