namespace LeetCodeCSharp.Easy;

public class PowerOfFourSolution
{
  public static bool IsPowerOfFour(int n)
  {
    int index = 0;

    while (n >= Math.Pow(4, index))
    {
      if (n == Math.Pow(4, index)) return true;
      index++;
    }

    return false;
  }
}


/*

Given an integer n, return true if it is a power of four. Otherwise, return false.

An integer n is a power of four, if there exists an integer x such that n == 4^x.

Example 1:

Input: n = 16
Output: true

Example 2:

Input: n = 5
Output: false

Example 3:

Input: n = 1
Output: true

*/
