namespace FizzBuzz;

public class Solution
{
  public static IList<string> FizzBuzz(int n)
  {
    List<string> fizzBuzz = [];

    for (int i = 1; i <= n; i++)
    {
      if (i % 15 == 0)
      {
        fizzBuzz.Add("FizzBuzz");
      }
      else if (i % 3 == 0)
      {
        fizzBuzz.Add("Fizz");
      }
      else if (i % 5 == 0)
      {
        fizzBuzz.Add("Buzz");
      }
      else
      {
        fizzBuzz.Add(i.ToString());
      }
    }

    return fizzBuzz;
  }

  public static void Test()
  {
    Console.WriteLine($"[{string.Join(", ", FizzBuzz(3))}]");
    Console.WriteLine($"[{string.Join(", ", FizzBuzz(5))}]");
    Console.WriteLine($"[{string.Join(", ", FizzBuzz(15))}]");
  }
}


/*

Given an integer n, return a string array answer (1-indexed) where:

answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
answer[i] == "Fizz" if i is divisible by 3.
answer[i] == "Buzz" if i is divisible by 5.
answer[i] == i (as a string) if none of the above conditions are true.
 
Example 1:

Input: n = 3
Output: ["1", "2", "Fizz"]

Example 2:

Input: n = 5
Output: ["1", "2", "Fizz", "4", "Buzz"]

Example 3:

Input: n = 15
Output: ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]

*/