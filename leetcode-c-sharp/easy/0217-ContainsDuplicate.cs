namespace ContainsDuplicate;

public class Solution
{
  public static bool ContainsDuplicate(int[] nums)
  {
    return nums.Length != new HashSet<int>(nums).Count;
  }

  public static void Test()
  {
    Console.WriteLine(ContainsDuplicate([1, 2, 3, 1]));
    // True
    Console.WriteLine(ContainsDuplicate([1, 2, 3, 4]));
    // False
    Console.WriteLine(ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]));
    // True
  }
}


/*

Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

Example 1:

Input: nums = [1, 2, 3, 1]
Output: true

Example 2:

Input: nums = [1, 2, 3, 4]
Output: false

Example 3:

Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
Output: true

*/
