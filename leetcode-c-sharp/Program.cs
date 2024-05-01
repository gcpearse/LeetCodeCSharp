namespace LeetCode
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length == 1)
      {
        switch (args[0])
        {
          case "1": TwoSum.Solution.Test(); break;
          case "9": PalindromeNumber.Solution.Test(); break;

          default: Console.WriteLine("Invalid argument."); break;
        }
      }
      else
      {
        Console.WriteLine("Please provide a single argument.");
      }
    }
  }
}
