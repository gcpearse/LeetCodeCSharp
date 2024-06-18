namespace LeetCodeCSharpTests;

public class EasyTests
{
  [Fact]
  public void TwoSumTest()
  {
    Assert.Equal([0, 1], LeetCodeCSharp.Easy.TwoSumSolution.TwoSum([2, 7, 11, 15], 9));
    Assert.Equal([2, 1], LeetCodeCSharp.Easy.TwoSumSolution.TwoSum([3, 2, 4], 6));
    Assert.Equal([0, 1], LeetCodeCSharp.Easy.TwoSumSolution.TwoSum([3, 3], 6));
  }

  [Fact]
  public void IsPalindromeTest()
  {
    Assert.True(LeetCodeCSharp.Easy.PalindromeNumberSolution.IsPalindrome(121));
    Assert.False(LeetCodeCSharp.Easy.PalindromeNumberSolution.IsPalindrome(-121));
    Assert.False(LeetCodeCSharp.Easy.PalindromeNumberSolution.IsPalindrome(10));
  }

  [Fact]
  public void RomanToIntTest()
  {
    Assert.Equal(3, LeetCodeCSharp.Easy.RomanToIntegerSolution.RomanToInt("III"));
    Assert.Equal(58, LeetCodeCSharp.Easy.RomanToIntegerSolution.RomanToInt("LVIII"));
    Assert.Equal(1994, LeetCodeCSharp.Easy.RomanToIntegerSolution.RomanToInt("MCMXCIV"));
  }

  [Fact]
  public void LongestCommonPrefixTest()
  {
    Assert.Equal("fl", LeetCodeCSharp.Easy.LongestCommonPrefixSolution.LongestCommonPrefix([
      "flower",
      "flow",
      "flight"
    ]));
    Assert.Equal("", LeetCodeCSharp.Easy.LongestCommonPrefixSolution.LongestCommonPrefix([
      "dog",
      "racecar",
      "car"
    ]));
  }

  [Fact]
  public void IsValidTest()
  {
    Assert.True(LeetCodeCSharp.Easy.ValidParenthesesSolution.IsValid("()"));
    Assert.True(LeetCodeCSharp.Easy.ValidParenthesesSolution.IsValid("()[]{}"));
    Assert.False(LeetCodeCSharp.Easy.ValidParenthesesSolution.IsValid("(]"));
    Assert.False(LeetCodeCSharp.Easy.ValidParenthesesSolution.IsValid("(])"));
  }

  [Fact]
  public void StrStrTest()
  {
    Assert.Equal(0, LeetCodeCSharp.Easy.FindFirstOccurrenceSolution.StrStr("sadbutsad", "sad"));
    Assert.Equal(-1, LeetCodeCSharp.Easy.FindFirstOccurrenceSolution.StrStr("leetcode", "leeto"));
  }

  [Fact]
  public void SearchInsertTest()
  {
    Assert.Equal(2, LeetCodeCSharp.Easy.SearchInsertPositionSolution.SearchInsert([1, 3, 5, 6], 5));
    Assert.Equal(1, LeetCodeCSharp.Easy.SearchInsertPositionSolution.SearchInsert([1, 3, 5, 6], 2));
    Assert.Equal(4, LeetCodeCSharp.Easy.SearchInsertPositionSolution.SearchInsert([1, 3, 5, 6], 7));
  }

  [Fact]
  public void LengthOfLastWordTest()
  {
    Assert.Equal(5, LeetCodeCSharp.Easy.LengthOfLastWordSolution.LengthOfLastWord("Hello World"));
    Assert.Equal(4, LeetCodeCSharp.Easy.LengthOfLastWordSolution.LengthOfLastWord("   fly me   to   the moon  "));
    Assert.Equal(6, LeetCodeCSharp.Easy.LengthOfLastWordSolution.LengthOfLastWord("luffy is still joyboy"));
  }

  [Fact]
  public void PlusOneTest()
  {
    Assert.Equal([1, 2, 4], LeetCodeCSharp.Easy.PlusOneSolution.PlusOne([1, 2, 3]));
    Assert.Equal([4, 3, 2, 2], LeetCodeCSharp.Easy.PlusOneSolution.PlusOne([4, 3, 2, 1]));
    Assert.Equal([1, 0], LeetCodeCSharp.Easy.PlusOneSolution.PlusOne([9]));
    Assert.Equal([1, 0, 0], LeetCodeCSharp.Easy.PlusOneSolution.PlusOne([9, 9]));
    Assert.Equal([1, 0, 0, 0], LeetCodeCSharp.Easy.PlusOneSolution.PlusOne([9, 9, 9]));
    Assert.Equal([2, 4, 0, 0], LeetCodeCSharp.Easy.PlusOneSolution.PlusOne([2, 3, 9, 9]));
    Assert.Equal([9, 9, 0], LeetCodeCSharp.Easy.PlusOneSolution.PlusOne([9, 8, 9]));
  }

  [Fact]
  public void MaxProfitTest()
  {
    Assert.Equal(5, LeetCodeCSharp.Easy.BestTimeToBuyAndSellStockSolution.MaxProfit([7, 1, 5, 3, 6, 4]));
    Assert.Equal(0, LeetCodeCSharp.Easy.BestTimeToBuyAndSellStockSolution.MaxProfit([7, 6, 4, 3, 1]));
  }

  [Fact]
  public void IsPalindromeTest2()
  {
    Assert.True(LeetCodeCSharp.Easy.ValidPalindromeSolution.IsPalindrome("A man, a plan, a canal: Panama"));
    Assert.False(LeetCodeCSharp.Easy.ValidPalindromeSolution.IsPalindrome("race a car"));
    Assert.True(LeetCodeCSharp.Easy.ValidPalindromeSolution.IsPalindrome(" "));
    Assert.True(LeetCodeCSharp.Easy.ValidPalindromeSolution.IsPalindrome(".,"));
    Assert.True(LeetCodeCSharp.Easy.ValidPalindromeSolution.IsPalindrome("aa"));
  }

  [Fact]
  public void SingleNumberTest()
  {
    Assert.Equal(1, LeetCodeCSharp.Easy.SingleNumberSolution.SingleNumber([2, 2, 1]));
    Assert.Equal(4, LeetCodeCSharp.Easy.SingleNumberSolution.SingleNumber([4, 1, 2, 1, 2]));
    Assert.Equal(1, LeetCodeCSharp.Easy.SingleNumberSolution.SingleNumber([1]));
  }

  [Fact]
  public void ConvertToTitleTest()
  {
    Assert.Equal("A", LeetCodeCSharp.Easy.ExcelSheetColumnTitleSolution.ConvertToTitle(1));
    Assert.Equal("AB", LeetCodeCSharp.Easy.ExcelSheetColumnTitleSolution.ConvertToTitle(28));
    Assert.Equal("ZY", LeetCodeCSharp.Easy.ExcelSheetColumnTitleSolution.ConvertToTitle(701));
  }

  [Fact]
  public void MajorityElementTest()
  {
    Assert.Equal(3, LeetCodeCSharp.Easy.MajorityElementSolution.MajorityElement([3, 2, 3]));
    Assert.Equal(2, LeetCodeCSharp.Easy.MajorityElementSolution.MajorityElement([2, 2, 1, 1, 1, 2, 2]));
    Assert.Equal(3, LeetCodeCSharp.Easy.MajorityElementSolution.MajorityElement([1, 2, 3, 3, 3, 3, 4]));
  }

  [Fact]
  public void TitleToNumberTest()
  {
    Assert.Equal(1, LeetCodeCSharp.Easy.ExcelSheetColumnNumberSolution.TitleToNumber("A"));
    Assert.Equal(28, LeetCodeCSharp.Easy.ExcelSheetColumnNumberSolution.TitleToNumber("AB"));
    Assert.Equal(701, LeetCodeCSharp.Easy.ExcelSheetColumnNumberSolution.TitleToNumber("ZY"));
  }

  [Fact]
  public void ContainsDuplicateTest()
  {
    Assert.True(LeetCodeCSharp.Easy.ContainsDuplicateSolution.ContainsDuplicate([1, 2, 3, 1]));
    Assert.False(LeetCodeCSharp.Easy.ContainsDuplicateSolution.ContainsDuplicate([1, 2, 3, 4]));
    Assert.True(LeetCodeCSharp.Easy.ContainsDuplicateSolution.ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]));
  }

  [Fact]
  public void IsPowerOfTwoTest()
  {
    Assert.True(LeetCodeCSharp.Easy.IsPowerOfTwoSolution.IsPowerOfTwo(1));
    Assert.True(LeetCodeCSharp.Easy.IsPowerOfTwoSolution.IsPowerOfTwo(8));
    Assert.True(LeetCodeCSharp.Easy.IsPowerOfTwoSolution.IsPowerOfTwo(16));
    Assert.False(LeetCodeCSharp.Easy.IsPowerOfTwoSolution.IsPowerOfTwo(3));
  }

  [Fact]
  public void IsAnagramTest()
  {
    Assert.True(LeetCodeCSharp.Easy.ValidAnagramSolution.IsAnagram("anagram", "nagaram"));
    Assert.False(LeetCodeCSharp.Easy.ValidAnagramSolution.IsAnagram("rat", "car"));
    Assert.False(LeetCodeCSharp.Easy.ValidAnagramSolution.IsAnagram("ac", "bb"));
  }

  [Fact]
  public void AddDigitsTest()
  {
    Assert.Equal(2, LeetCodeCSharp.Easy.AddDigitsSolution.AddDigits(38));
    Assert.Equal(0, LeetCodeCSharp.Easy.AddDigitsSolution.AddDigits(0));
  }

  [Fact]
  public void MissingNumberTest()
  {
    Assert.Equal(2, LeetCodeCSharp.Easy.MissingNumberSolution.MissingNumber([3, 0, 1]));
    Assert.Equal(2, LeetCodeCSharp.Easy.MissingNumberSolution.MissingNumber([0, 1]));
    Assert.Equal(8, LeetCodeCSharp.Easy.MissingNumberSolution.MissingNumber([9, 6, 4, 2, 3, 5, 7, 0, 1]));
  }

  [Fact]
  public void WordPatternTest()
  {
    Assert.True(LeetCodeCSharp.Easy.WordPatternSolution.WordPattern("abba", "dog cat cat dog"));
    Assert.False(LeetCodeCSharp.Easy.WordPatternSolution.WordPattern("abba", "dog cat cat fish"));
    Assert.False(LeetCodeCSharp.Easy.WordPatternSolution.WordPattern("aaaa", "dog cat cat dog"));
    Assert.False(LeetCodeCSharp.Easy.WordPatternSolution.WordPattern("abba", "dog dog dog dog"));
  }

  [Fact]
  public void IsPowerOfThreeTest()
  {
    Assert.True(LeetCodeCSharp.Easy.PowerOfThreeSolution.IsPowerOfThree(27));
    Assert.False(LeetCodeCSharp.Easy.PowerOfThreeSolution.IsPowerOfThree(0));
    Assert.False(LeetCodeCSharp.Easy.PowerOfThreeSolution.IsPowerOfThree(-1));
  }

  [Fact]
  public void IsPowerOfFourTest()
  {
    Assert.True(LeetCodeCSharp.Easy.PowerOfFourSolution.IsPowerOfFour(16));
    Assert.False(LeetCodeCSharp.Easy.PowerOfFourSolution.IsPowerOfFour(5));
    Assert.True(LeetCodeCSharp.Easy.PowerOfFourSolution.IsPowerOfFour(1));
  }

  [Fact]
  public void ReverseVowelsTest()
  {
    Assert.Equal("holle", LeetCodeCSharp.Easy.ReverseVowelsOfStringSolution.ReverseVowels("hello"));
    Assert.Equal("leotcede", LeetCodeCSharp.Easy.ReverseVowelsOfStringSolution.ReverseVowels("leetcode"));
  }

  [Fact]
  public void IntersectionTest()
  {
    Assert.Equal([2], LeetCodeCSharp.Easy.IntersectionOfTwoArraysSolution.Intersection([1, 2, 2, 1], [2, 2]));
    Assert.Equal([4, 9], LeetCodeCSharp.Easy.IntersectionOfTwoArraysSolution.Intersection([4, 9, 5], [9, 4, 9, 8, 4]));
  }

  [Fact]
  public void IsPerfectSquareTest()
  {
    Assert.True(LeetCodeCSharp.Easy.ValidPerfectSquareSolution.IsPerfectSquare(16));
    Assert.False(LeetCodeCSharp.Easy.ValidPerfectSquareSolution.IsPerfectSquare(14));
  }

  [Fact]
  public void CanConstructTest()
  {
    Assert.False(LeetCodeCSharp.Easy.RansomNoteSolution.CanConstruct("a", "b"));
    Assert.False(LeetCodeCSharp.Easy.RansomNoteSolution.CanConstruct("aa", "ab"));
    Assert.True(LeetCodeCSharp.Easy.RansomNoteSolution.CanConstruct("aa", "aab"));
    Assert.True(LeetCodeCSharp.Easy.RansomNoteSolution.CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"));
  }

  [Fact]
  public void FirstUniqCharTest()
  {
    Assert.Equal(0, LeetCodeCSharp.Easy.FirstUniqueCharacterInStringSolution.FirstUniqChar("leetcode"));
    Assert.Equal(2, LeetCodeCSharp.Easy.FirstUniqueCharacterInStringSolution.FirstUniqChar("loveleetcode"));
    Assert.Equal(-1, LeetCodeCSharp.Easy.FirstUniqueCharacterInStringSolution.FirstUniqChar("aabb"));
  }

  [Fact]
  public void FindTheDifferenceTest()
  {
    Assert.Equal('e', LeetCodeCSharp.Easy.FindTheDifferenceSolution.FindTheDifference("abcd", "abcde"));
    Assert.Equal('y', LeetCodeCSharp.Easy.FindTheDifferenceSolution.FindTheDifference("", "y"));
  }

  [Fact]
  public void IsSubsequenceTest()
  {
    Assert.True(LeetCodeCSharp.Easy.IsSubsequenceSolution.IsSubsequence("abc", "ahbgdc"));
    Assert.False(LeetCodeCSharp.Easy.IsSubsequenceSolution.IsSubsequence("axc", "ahbgdc"));
    Assert.False(LeetCodeCSharp.Easy.IsSubsequenceSolution.IsSubsequence("acb", "ahbgdc"));
    Assert.True(LeetCodeCSharp.Easy.IsSubsequenceSolution.IsSubsequence("b", "abc"));
  }

  [Fact]
  public void LongestPalindromeTest()
  {
    Assert.Equal(7, LeetCodeCSharp.Easy.LongestPalindromeSolution.LongestPalindrome("abccccdd"));
    Assert.Equal(1, LeetCodeCSharp.Easy.LongestPalindromeSolution.LongestPalindrome("a"));
  }

  [Fact]
  public void FizzBuzzTest()
  {
    Assert.Equal(["1", "2", "Fizz"], LeetCodeCSharp.Easy.FizzBuzzSolution.FizzBuzz(3));
    Assert.Equal(["1", "2", "Fizz", "4", "Buzz"], LeetCodeCSharp.Easy.FizzBuzzSolution.FizzBuzz(5));
    Assert.Equal(["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"], LeetCodeCSharp.Easy.FizzBuzzSolution.FizzBuzz(15));
  }

  [Fact]
  public void ThirdMaxTest()
  {
    Assert.Equal(1, LeetCodeCSharp.Easy.ThirdMaximumNumberSolution.ThirdMax([3, 2, 1]));
    Assert.Equal(2, LeetCodeCSharp.Easy.ThirdMaximumNumberSolution.ThirdMax([1, 2]));
    Assert.Equal(1, LeetCodeCSharp.Easy.ThirdMaximumNumberSolution.ThirdMax([2, 2, 3, 1]));
  }

  [Fact]
  public void CountSegmentsTest()
  {
    Assert.Equal(5, LeetCodeCSharp.Easy.NumberOfSegmentsInStringSolution.CountSegments("Hello, my name is John"));
    Assert.Equal(1, LeetCodeCSharp.Easy.NumberOfSegmentsInStringSolution.CountSegments("Hello"));
    Assert.Equal(0, LeetCodeCSharp.Easy.NumberOfSegmentsInStringSolution.CountSegments(""));
  }

  [Fact]
  public void ArrangeCoinsTest()
  {
    Assert.Equal(2, LeetCodeCSharp.Easy.ArrangingCoinsSolution.ArrangeCoins(5));
    Assert.Equal(3, LeetCodeCSharp.Easy.ArrangingCoinsSolution.ArrangeCoins(8));
    Assert.Equal(1, LeetCodeCSharp.Easy.ArrangingCoinsSolution.ArrangeCoins(1));
  }

  [Fact]
  public void FindDisappearedNumbersTest()
  {
    Assert.Equal([5, 6], LeetCodeCSharp.Easy.FindAllNumbersDisappearedInAnArraySolution.FindDisappearedNumbers([4, 3, 2, 7, 8, 2, 3, 1]));
    Assert.Equal([2], LeetCodeCSharp.Easy.FindAllNumbersDisappearedInAnArraySolution.FindDisappearedNumbers([1, 1]));
  }

  [Fact]
  public void FindContentChildrenTest()
  {
    Assert.Equal(1, LeetCodeCSharp.Easy.AssignCookiesSolution.FindContentChildren([1, 2, 3], [1, 1]));
    Assert.Equal(2, LeetCodeCSharp.Easy.AssignCookiesSolution.FindContentChildren([1, 2], [1, 2, 3]));
  }

  [Fact]
  public void LicenseKeyFormattingTest()
  {
    Assert.Equal("5F3Z-2E9W", LeetCodeCSharp.Easy.LicenseKeyFormattingSolution.LicenseKeyFormatting("5F3Z-2e-9-w", 4));
    Assert.Equal("2-5G-3J", LeetCodeCSharp.Easy.LicenseKeyFormattingSolution.LicenseKeyFormatting("2-5g-3-J", 2));
    Assert.Equal("AA-AA", LeetCodeCSharp.Easy.LicenseKeyFormattingSolution.LicenseKeyFormatting("--a-a-a-a--", 2));
  }

  [Fact]
  public void FindMaxConsecutiveOnesTest()
  {
    Assert.Equal(3, LeetCodeCSharp.Easy.MaxConsecutiveOnesSolution.FindMaxConsecutiveOnes([1, 1, 0, 1, 1, 1]));
    Assert.Equal(2, LeetCodeCSharp.Easy.MaxConsecutiveOnesSolution.FindMaxConsecutiveOnes([1, 0, 1, 1, 0, 1]));
  }

  [Fact]
  public void FindPoisonedDurationTest()
  {
    Assert.Equal(4, LeetCodeCSharp.Easy.TeemoAttackingSolution.FindPoisonedDuration([1, 4], 2));
    Assert.Equal(3, LeetCodeCSharp.Easy.TeemoAttackingSolution.FindPoisonedDuration([1, 2], 2));
  }

  [Fact]
  public void NextGreaterElementTest()
  {
    Assert.Equal([-1, 3, -1], LeetCodeCSharp.Easy.NextGreaterElementSolution.NextGreaterElement([4, 1, 2], [1, 3, 4, 2]));
    Assert.Equal([3, -1], LeetCodeCSharp.Easy.NextGreaterElementSolution.NextGreaterElement([2, 4], [1, 2, 3, 4]));
  }

  [Fact]
  public void FindWordsTest()
  {
    Assert.Equal(["Alaska", "Dad"], LeetCodeCSharp.Easy.KeyboardRowSolution.FindWords(["Hello", "Alaska", "Dad", "Peace"]));
    Assert.Equal([], LeetCodeCSharp.Easy.KeyboardRowSolution.FindWords(["omk"]));
    Assert.Equal(["adsdf", "sfd"], LeetCodeCSharp.Easy.KeyboardRowSolution.FindWords(["adsdf", "sfd"]));
  }

  [Fact]
  public void FindRelativeRanksTest()
  {
    Assert.Equal(["Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"], LeetCodeCSharp.Easy.RelativeRanksSolution.FindRelativeRanks([5, 4, 3, 2, 1]));
    Assert.Equal(["Gold Medal", "5", "Bronze Medal", "Silver Medal", "4"], LeetCodeCSharp.Easy.RelativeRanksSolution.FindRelativeRanks([10, 3, 8, 9, 4]));
  }

  [Fact]
  public void DetectCapitalUseTest()
  {
    Assert.True(LeetCodeCSharp.Easy.DetectCapitalSolution.DetectCapitalUse("USA"));
    Assert.False(LeetCodeCSharp.Easy.DetectCapitalSolution.DetectCapitalUse("FlaG"));
  }

  [Fact]
  public void CheckRecordTest()
  {
    Assert.True(LeetCodeCSharp.Easy.StudentAttendanceRecordISolution.CheckRecord("PPALLP"));
    Assert.False(LeetCodeCSharp.Easy.StudentAttendanceRecordISolution.CheckRecord("PPALLL"));
  }

  [Fact]
  public void ReverseWordsTest()
  {
    Assert.Equal("s'teL ekat edoCteeL tsetnoc", LeetCodeCSharp.Easy.ReverseWordsInAStringIIISolution.ReverseWords("Let's take LeetCode contest"));
    Assert.Equal("rM gniD", LeetCodeCSharp.Easy.ReverseWordsInAStringIIISolution.ReverseWords("Mr Ding"));
  }

  [Fact]
  public void DistributeCandiesTest()
  {
    Assert.Equal(3, LeetCodeCSharp.Easy.DistributeCandiesSolution.DistributeCandies([1, 1, 2, 2, 3, 3]));
    Assert.Equal(2, LeetCodeCSharp.Easy.DistributeCandiesSolution.DistributeCandies([1, 1, 2, 3]));
    Assert.Equal(1, LeetCodeCSharp.Easy.DistributeCandiesSolution.DistributeCandies([6, 6, 6, 6]));
  }
}
