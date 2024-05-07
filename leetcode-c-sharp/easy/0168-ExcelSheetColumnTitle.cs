namespace ExcelSheetColumnTitle;

public class Solution
{
  public static string ConvertToTitle(int columnNumber)
  {
    int current = columnNumber;
    string result = "";

    while (current > 0)
    {
      int remainder = current % 26;
      current -= remainder;

      if (remainder > 0)
      {
        result = Convert.ToChar(remainder + 64) + result;
        current /= 26;
      }
      else
      {
        result = 'Z' + result;
        current = current / 26 - 1;
      }
    }

    return result;
  }

  public static void Test()
  {
    Console.WriteLine(ConvertToTitle(1));
    // A
    Console.WriteLine(ConvertToTitle(28));
    // AB
    Console.WriteLine(ConvertToTitle(701));
    // ZY
  }
}


/*

Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...
 
Example 1:

Input: columnNumber = 1
Output: "A"

Example 2:

Input: columnNumber = 28
Output: "AB"

Example 3:

Input: columnNumber = 701
Output: "ZY"

*/
