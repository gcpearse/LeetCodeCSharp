namespace MaxConsecutiveOnes;

public class Solution
{
  public static int FindMaxConsecutiveOnes(int[] nums)
  {
    int max = 0;
    int count = 0;

    foreach (int num in nums)
    {
      if (num == 1)
      {
        count++;
      }
      else
      {
        count = 0;
      }

      if (count > max) max = count;
    }

    return max;
  }

  public static void Test()
  {
    Console.WriteLine(FindMaxConsecutiveOnes([1, 1, 0, 1, 1, 1]));
    // 3
    Console.WriteLine(FindMaxConsecutiveOnes([1, 0, 1, 1, 0, 1]));
    // 2
  }
}


/*

Given a binary array nums, return the maximum number of consecutive 1s in the array.

Example 1:

Input: nums = [1, 1, 0, 1, 1, 1]
Output: 3
Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.

Example 2:

Input: nums = [1, 0, 1, 1, 0, 1]
Output: 2

*/
