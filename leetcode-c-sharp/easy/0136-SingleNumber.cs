namespace SingleNumber;

public class Solution
{
  public static int SingleNumber(int[] nums)
  {
    List<int> result = [];

    foreach (int num in nums)
    {
      if (!result.Remove(num))
      {
        result.Add(num);
      }
    }

    return result[0];
  }

  public static void Test()
  {
    Console.WriteLine(SingleNumber([2, 2, 1]));
    // 1
    Console.WriteLine(SingleNumber([4, 1, 2, 1, 2]));
    // 4
    Console.WriteLine(SingleNumber([1]));
    // 1
  }
}


/*

Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.

Example 1:

Input: nums = [2, 2, 1]
Output: 1

Example 2:

Input: nums = [4, 1, 2, 1, 2]
Output: 4

Example 3:

Input: nums = [1]
Output: 1

*/
