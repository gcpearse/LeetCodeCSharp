namespace MajorityElement;

public class Solution
{
  public static int MajorityElement(int[] nums)
  {
    Array.Sort(nums);
    
    return nums[nums.Length / 2];
  }

  public static void Test()
  {
    Console.WriteLine(MajorityElement([3, 2, 3]));
    // 3
    Console.WriteLine(MajorityElement([2, 2, 1, 1, 1, 2, 2]));
    // 2
    Console.WriteLine(MajorityElement([1, 2, 3, 3, 3, 3, 4]));
    // 2
  }
}


/*

Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

Example 1:

Input: nums = [3, 2, 3]
Output: 3

Example 2:

Input: nums = [2, 2, 1, 1, 1, 2, 2]
Output: 2

*/
