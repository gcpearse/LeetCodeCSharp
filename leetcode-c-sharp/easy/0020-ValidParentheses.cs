namespace ValidParentheses;

public class Solution
{
  public static bool IsValid(string s)
  {
    Dictionary<char, char> brackets = new()
    {
      { '(', ')' },
      { '[', ']' },
      { '{', '}' },
    };

    Stack<char> stack = [];

    foreach (char bracket in s)
    {
      if (brackets.ContainsKey(bracket))
      {
        stack.Push(bracket);
      }
      else if (stack.Count > 0 && bracket == brackets[stack.Peek()])
      {
        stack.Pop();
      }
      else
      {
        return false;
      }
    }

    return stack.Count == 0;
  }

  public static void Test()
  {
    Console.WriteLine(IsValid("()"));
    // True
    Console.WriteLine(IsValid("()[]{}"));
    // True
    Console.WriteLine(IsValid("(]"));
    // False
    Console.WriteLine(IsValid("(])"));
    // False
  }
}


/* 

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 
Example 1:

Input: s = "()"
Output: true

Example 2:

Input: s = "()[]{}"
Output: true

Example 3:

Input: s = "(]"
Output: false

*/

// char[] openers = ['(', '[', '{'];
// char[] closers = [')', ']', '}'];

// Stack<char> stack = [];

// foreach (char bracket in s)
// {
//   if (Array.IndexOf(openers, bracket) != -1)
//   {
//     stack.Push(bracket);
//   }
//   else if (stack.Count == 0 && Array.IndexOf(closers, bracket) != -1)
//   {
//     return false;
//   }
//   else
//   {
//     if (stack.Count > 0)
//     {
//       if (Array.IndexOf(closers, bracket) == Array.IndexOf(openers, stack.Peek()))
//       {
//         stack.Pop();
//       }
//       else
//       {
//         return false;
//       }
//     }
//   }
// }

// return stack.Count == 0;