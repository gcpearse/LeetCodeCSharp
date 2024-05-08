namespace PowerOfThree;

public class Solution
{
  public static bool IsPowerOfThree(int n)
  {
    int index = 0;

    while (n >= Math.Pow(3, index))
    {
      if (n == Math.Pow(3, index)) return true;
      index++;
    }

    return false;
  }

  public static void Test()
  {
    Console.WriteLine(IsPowerOfThree(27));
    // True
    Console.WriteLine(IsPowerOfThree(0));
    // False
    Console.WriteLine(IsPowerOfThree(-1));
    // False
  }
}


/*

Given an integer n, return true if it is a power of three. Otherwise, return false.

An integer n is a power of three, if there exists an integer x such that n == 3^x.

Example 1:

Input: n = 27
Output: true
Explanation: 27 = 3^3

Example 2:

Input: n = 0
Output: false
Explanation: There is no x where 3^x = 0.

Example 3:

Input: n = -1
Output: false
Explanation: There is no x where 3^x = (-1).

*/
