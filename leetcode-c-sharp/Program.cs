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
      case "20": ValidParentheses.Solution.Test(); break;
      case "28": FindFirstOccurrence.Solution.Test(); break;
      case "35": SearchInsertPosition.Solution.Test(); break;
      case "58": LengthOfLastWord.Solution.Test(); break;
      case "66": PlusOne.Solution.Test(); break;
      case "121": BestTimeToBuyAndSellStock.Solution.Test(); break;
      case "125": ValidPalindrome.Solution.Test(); break;
      case "136": SingleNumber.Solution.Test(); break;
      case "168": ExcelSheetColumnTitle.Solution.Test(); break;
      case "169": MajorityElement.Solution.Test(); break;
      case "171": ExcelSheetColumnNumber.Solution.Test(); break;
      case "217": ContainsDuplicate.Solution.Test(); break;
      case "231": IsPowerOfTwo.Solution.Test(); break;
      case "242": ValidAnagram.Solution.Test(); break;
      case "258": AddDigits.Solution.Test(); break;
      case "268": MissingNumber.Solution.Test(); break;
      case "290": WordPattern.Solution.Test(); break;

      default: Console.WriteLine("Invalid argument."); break;
    }
  }
}
