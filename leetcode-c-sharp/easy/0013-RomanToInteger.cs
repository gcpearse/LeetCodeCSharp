namespace RomanToInteger;

public class Solution
{
  public static int RomanToInt(string s)
  {
    Dictionary<char, int> romanValues = new()
    {
      {'M', 1000},
      {'D', 500},
      {'C', 100},
      {'L', 50},
      {'X', 10},
      {'V', 5},
      {'I', 1}
    };

    int result = 0;

    for (int i = 0; i < s.Length; i++)
    {
      if (i == s.Length - 1)
      {
        result += romanValues[s[i]];
        break;
      }
      if (romanValues[s[i]] < romanValues[s[i + 1]])
      {
        result -= romanValues[s[i]];
      }
      else
      {
        result += romanValues[s[i]];
      }
    }

    return result;
  }

  public static void Test()
  {
    Console.WriteLine(RomanToInt("III"));
    // 3
    Console.WriteLine(RomanToInt("LVIII"));
    // 58
    Console.WriteLine(RomanToInt("MCMXCIV"));
    // 1994
  }
}


/*

Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

For example, 2 is written as II in Roman numeral, just two ones added together. 
12 is written as XII, which is simply X + II. 
The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. 
However, the numeral for four is not IIII. Instead, the number four is written as IV. 
Because the one is before the five we subtract it making four. 
The same principle applies to the number nine, which is written as IX. 
There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

*/
