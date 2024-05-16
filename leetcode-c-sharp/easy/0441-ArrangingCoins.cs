namespace ArrangingCoins;

public class Solution
{
  public static int ArrangeCoins(int n)
  {
    int row = 0;

    while (n - row >= 0)
    {
      n -= row;
      row++;
    }

    return row - 1;
  }

  public static void Test()
  {
    Console.WriteLine(ArrangeCoins(5));
    // 2
    Console.WriteLine(ArrangeCoins(8));
    // 3
    Console.WriteLine(ArrangeCoins(1));
    // 1
  }
}


/*

You have n coins and you want to build a staircase with these coins. The staircase consists of k rows where the ith row has exactly i coins. The last row of the staircase may be incomplete.

Given the integer n, return the number of complete rows of the staircase you will build.

Example 1:

Input: n = 5
Output: 2
Explanation: Because the 3rd row is incomplete, we return 2.

Example 2:

Input: n = 8
Output: 3
Explanation: Because the 4th row is incomplete, we return 3.

*/
