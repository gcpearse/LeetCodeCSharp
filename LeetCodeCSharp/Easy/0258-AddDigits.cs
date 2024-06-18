namespace LeetCodeCSharp.Easy;

public class AddDigitsSolution
{
  public static int AddDigits(int num)
  {
    if (num < 10) return num;

    int subtotal = 0;

    while (num > 0)
    {
      subtotal += num % 10;
      num /= 10;
    }

    return AddDigits(subtotal);
  }
}


/*

Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

Example 1:

Input: num = 38
Output: 2
Explanation: The process is
38 --> 3 + 8 --> 11
11 --> 1 + 1 --> 2 
Since 2 has only one digit, return it.

Example 2:

Input: num = 0
Output: 0

*/
