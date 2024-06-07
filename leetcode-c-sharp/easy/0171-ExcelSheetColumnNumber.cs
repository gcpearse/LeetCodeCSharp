namespace ExcelSheetColumnNumber;

public class Solution
{
  public static int TitleToNumber(string columnTitle)
  {
    int result = 0;
    int multiplier = 1;

    for (int i = columnTitle.Length - 1; i >= 0 ; i--)
    {
      result += (columnTitle[i] - 64) * multiplier;
      multiplier *= 26;
    }

    return result;
  }
}


/*

Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.

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

Input: columnTitle = "A"
Output: 1

Example 2:

Input: columnTitle = "AB"
Output: 28

Example 3:

Input: columnTitle = "ZY"
Output: 701

*/
