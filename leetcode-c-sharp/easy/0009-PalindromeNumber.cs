namespace PalindromeNumber;

public class Solution
{
  public static bool IsPalindrome(int x)
  {
    string str = Convert.ToString(x);

    int left = 0;
    int right = str.Length - 1;

    while (left <= right)
    {
      if (str[left] != str[right]) return false;

      left++;
      right--;
    }

    return true;
  }
}


/* 

Given an integer x, return true if x is a palindrome, and false otherwise.

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

*/
