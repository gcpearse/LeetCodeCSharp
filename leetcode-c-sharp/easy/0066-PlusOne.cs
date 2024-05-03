namespace PlusOne;

public class Solution
{
  public static int[] PlusOne(int[] digits)
  {
    List<int> result = [];

    if (digits.All(digit => digit == 9))
    {
      foreach (int digit in digits)
      {
        result.Insert(0, 0);
      }
      result.Insert(0, 1);
      return [.. result];
    }

    if (digits[^1] != 9)
    {
      result = [.. digits];
      result[^1]++;
      return [.. result];
    }

    bool toggle = true;

    for (int i = digits.Length - 1; i >= 0; i--)
    {
      if (toggle && digits[i] == 9)
      {
        result.Insert(0, 0);
      }
      else
      {
        if (toggle)
        {
          result.Insert(0, digits[i] + 1);
        }
        else
        {
          result.Insert(0, digits[i]);
        }
        toggle = false;
      }
    }

    return [.. result];
  }

  public static void Test()
  {
    Console.WriteLine(string.Join(" ", PlusOne([1, 2, 3])));
    // [1, 2, 4]
    Console.WriteLine(string.Join(" ", PlusOne([4, 3, 2, 1])));
    // [4, 3, 2, 2]
    Console.WriteLine(string.Join(" ", PlusOne([9])));
    // [1, 0]   
    Console.WriteLine(string.Join(" ", PlusOne([9, 9])));
    // [1, 0, 0]   
    Console.WriteLine(string.Join(" ", PlusOne([9, 9, 9])));
    // [1, 0, 0, 0] 
    Console.WriteLine(string.Join(" ", PlusOne([2, 3, 9, 9])));
    // [2, 4, 0, 0]     
    Console.WriteLine(string.Join(" ", PlusOne([9, 8, 9])));
    // [9, 9, 0]  
  }
}


/*

You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
The digits are ordered from most significant to least significant in left-to-right order. 
The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.

Example 1:

Input: digits = [1, 2, 3]
Output: [1, 2, 4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1, 2, 4].

Example 2:

Input: digits = [4, 3, 2, 1]
Output: [4, 3, 2, 2]
Explanation: The array represents the integer 4321.
Incrementing by one gives 4321 + 1 = 4322.
Thus, the result should be [4, 3, 2, 2].

Example 3:

Input: digits = [9]
Output: [1, 0]
Explanation: The array represents the integer 9.
Incrementing by one gives 9 + 1 = 10.
Thus, the result should be [1, 0].

*/
