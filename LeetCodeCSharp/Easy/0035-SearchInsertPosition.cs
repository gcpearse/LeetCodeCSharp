namespace LeetCodeCSharp.Easy;

public class SearchInsertPositionSolution
{
  public static int SearchInsert(int[] nums, int target)
  {
    if (target < nums[0]) return 0;
    if (target > nums[^1]) return nums.Length;

    int result = 0;

    for (int i = 0; i < nums.Length - 1; i++)
    {
      if (target > nums[i] && target <= nums[i + 1])
      {
        result = i + 1;
        break;
      }
    }

    return result;
  }
}


/*

Given a sorted array of distinct integers and a target value, return the index if the target is found. 
If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

Example 1:

Input: nums = [1, 3, 5, 6], target = 5
Output: 2

Example 2:

Input: nums = [1, 3, 5, 6], target = 2
Output: 1

Example 3:

Input: nums = [1, 3, 5, 6], target = 7
Output: 4

*/
