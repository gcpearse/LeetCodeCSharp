namespace LeetCode;

class Program
{
  static void Main(string[] args)
  {
    if (args.Length == 1)
    {
      TestSolution(args[0]);
    }
    else
    {
      Console.WriteLine("Please provide a single argument.");
    }
  }

  static void TestSolution(string arg)
  {
    switch (arg)
    {
      case "1": TwoSum.Solution.Test(); break;
      case "9": PalindromeNumber.Solution.Test(); break;
      case "13": RomanToInteger.Solution.Test(); break;
      case "14": LongestCommonPrefix.Solution.Test(); break;

      default: Console.WriteLine("Invalid argument."); break;
    }
  }
}
