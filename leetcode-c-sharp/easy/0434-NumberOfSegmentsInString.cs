namespace NumberOfSegmentsInString;

public class Solution
{
  public static int CountSegments(string s)
  {
    string[] segments = s.Split();

    int count = 0;

    foreach (string segment in segments)
    {
      if (string.IsNullOrEmpty(segment)) continue;
      
      count++;
    }

    return count;
  }

  public static void Test()
  {
    Console.WriteLine(CountSegments("Hello, my name is John"));
    // 5
    Console.WriteLine(CountSegments("Hello"));
    // 1
    Console.WriteLine(CountSegments(""));
    // 0
    Console.WriteLine(CountSegments("Of all the gin joints in all the towns in all the world,   "));
    // 13
    Console.WriteLine(CountSegments(", , , ,        a, eaefa"));
    // 6
  }
}


/*

Given a string s, return the number of segments in the string.

A segment is defined to be a contiguous sequence of non-space characters.

Example 1:

Input: s = "Hello, my name is John"
Output: 5
Explanation: The five segments are ["Hello,", "my", "name", "is", "John"]

Example 2:

Input: s = "Hello"
Output: 1

*/
