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
      case "326": PowerOfThree.Solution.Test(); break;
      case "342": PowerOfFour.Solution.Test(); break;
      case "345": ReverseVowelsOfString.Solution.Test(); break;
      case "349": IntersectionOfTwoArrays.Solution.Test(); break;
      case "367": ValidPerfectSquare.Solution.Test(); break;
      case "383": RansomNote.Solution.Test(); break;
      case "387": FirstUniqueCharacterInString.Solution.Test(); break;
      case "389": FindTheDifference.Solution.Test(); break;
      case "392": IsSubsequence.Solution.Test(); break;
      case "409": LongestPalindrome.Solution.Test(); break;
      case "412": FizzBuzz.Solution.Test(); break;
      case "414": ThirdMaximumNumber.Solution.Test(); break;
      case "434": NumberOfSegmentsInString.Solution.Test(); break;
      case "441": ArrangingCoins.Solution.Test(); break;
      case "448": FindAllNumbersDisappearedInAnArray.Solution.Test(); break;
      case "455": AssignCookies.Solution.Test(); break;
      case "482": LicenseKeyFormatting.Solution.Test(); break;
      case "485": MaxConsecutiveOnes.Solution.Test(); break;
      case "495": TeemoAttacking.Solution.Test(); break;
      case "496": NextGreaterElement.Solution.Test(); break;
      case "500": KeyboardRow.Solution.Test(); break;
      case "506": RelativeRanks.Solution.Test(); break;
      case "520": DetectCapital.Solution.Test(); break;
      case "551": StudentAttendanceRecordI.Solution.Test(); break;

      default: Console.WriteLine("Invalid argument."); break;
    }
  }
}
