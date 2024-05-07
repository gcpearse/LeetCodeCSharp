namespace IsPowerOfTwo;

public class Solution
{
  public static bool IsPowerOfTwo(int n)
  {
    int index = 0;

    while (n >= Math.Pow(2, index))
    {
      if (n == Math.Pow(2, index)) return true;
      index++;
    }

    return false;
  }

  public static void Test()
  {
    Console.WriteLine(IsPowerOfTwo(1));
    // True
    Console.WriteLine(IsPowerOfTwo(8));
    // True
    Console.WriteLine(IsPowerOfTwo(16));
    // True
    Console.WriteLine(IsPowerOfTwo(3));
    // False
  }
}


/*

Given an integer n, return true if it is a power of two. Otherwise, return false.

An integer n is a power of two, if there exists an integer x such that n == 2x.

Example 1:

Input: n = 1
Output: true
Explanation: 2^0 = 1

Example 2:

Input: n = 16
Output: true
Explanation: 2^4 = 16

Example 3:

Input: n = 3
Output: false

*/
