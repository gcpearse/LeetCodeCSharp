namespace IntersectionOfTwoArrays;

public class Solution
{
  public static int[] Intersection(int[] nums1, int[] nums2)
  {
    return nums1.Intersect(nums2).ToArray();
  }

  public static void Test()
  {
    Console.WriteLine($"[{string.Join(", ", Intersection([1, 2, 2, 1], [2, 2]))}]");
    // [2]
    Console.WriteLine($"[{string.Join(", ", Intersection([4, 9, 5], [9, 4, 9, 8, 4]))}]");
    // [9, 4] or [4, 9]
  }
}


/*

Given two integer arrays nums1 and nums2, return an array of their intersection. 
Each element in the result must be unique and you may return the result in any order.

Example 1:

Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
Output: [2]

Example 2:

Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
Output: [9, 4]
Explanation: [4, 9] is also accepted.

*/
