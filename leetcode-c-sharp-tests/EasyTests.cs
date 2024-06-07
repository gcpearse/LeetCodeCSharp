namespace EasyTests;

public class Tests
{
  [Fact]
  public void TwoSumTest()
  {
    Assert.Equal([0, 1], TwoSum.Solution.TwoSum([2, 7, 11, 15], 9));
    Assert.Equal([2, 1], TwoSum.Solution.TwoSum([3, 2, 4], 6));
    Assert.Equal([0, 1], TwoSum.Solution.TwoSum([3, 3], 6));
  }

  [Fact]
  public void IsPalindromeTest()
  {
    Assert.True(PalindromeNumber.Solution.IsPalindrome(121));
    Assert.False(PalindromeNumber.Solution.IsPalindrome(-121));
    Assert.False(PalindromeNumber.Solution.IsPalindrome(10));
  }

  [Fact]
  public void RomanToIntTest()
  {
    Assert.Equal(3, RomanToInteger.Solution.RomanToInt("III"));
    Assert.Equal(58, RomanToInteger.Solution.RomanToInt("LVIII"));
    Assert.Equal(1994, RomanToInteger.Solution.RomanToInt("MCMXCIV"));
  }

  [Fact]
  public void LongestCommonPrefixTest()
  {
    Assert.Equal("fl", LongestCommonPrefix.Solution.LongestCommonPrefix([
      "flower",
      "flow",
      "flight"
    ]));
    Assert.Equal("", LongestCommonPrefix.Solution.LongestCommonPrefix([
      "dog",
      "racecar",
      "car"
    ]));
  }

  [Fact]
  public void IsValidTest()
  {
    Assert.True(ValidParentheses.Solution.IsValid("()"));
    Assert.True(ValidParentheses.Solution.IsValid("()[]{}"));
    Assert.False(ValidParentheses.Solution.IsValid("(]"));
    Assert.False(ValidParentheses.Solution.IsValid("(])"));
  }

  [Fact]
  public void StrStrTest()
  {
    Assert.Equal(0, FindFirstOccurrence.Solution.StrStr("sadbutsad", "sad"));
    Assert.Equal(-1, FindFirstOccurrence.Solution.StrStr("leetcode", "leeto"));
  }

  [Fact]
  public void SearchInsertTest()
  {
    Assert.Equal(2, SearchInsertPosition.Solution.SearchInsert([1, 3, 5, 6], 5));
    Assert.Equal(1, SearchInsertPosition.Solution.SearchInsert([1, 3, 5, 6], 2));
    Assert.Equal(4, SearchInsertPosition.Solution.SearchInsert([1, 3, 5, 6], 7));
  }

  [Fact]
  public void LengthOfLastWordTest()
  {
    Assert.Equal(5, LengthOfLastWord.Solution.LengthOfLastWord("Hello World"));
    Assert.Equal(4, LengthOfLastWord.Solution.LengthOfLastWord("   fly me   to   the moon  "));
    Assert.Equal(6, LengthOfLastWord.Solution.LengthOfLastWord("luffy is still joyboy"));
  }

  [Fact]
  public void PlusOneTest()
  {
    Assert.Equal([1, 2, 4], PlusOne.Solution.PlusOne([1, 2, 3]));
    Assert.Equal([4, 3, 2, 2], PlusOne.Solution.PlusOne([4, 3, 2, 1]));
    Assert.Equal([1, 0], PlusOne.Solution.PlusOne([9]));
    Assert.Equal([1, 0, 0], PlusOne.Solution.PlusOne([9, 9]));
    Assert.Equal([1, 0, 0, 0], PlusOne.Solution.PlusOne([9, 9, 9]));
    Assert.Equal([2, 4, 0, 0], PlusOne.Solution.PlusOne([2, 3, 9, 9]));
    Assert.Equal([9, 9, 0], PlusOne.Solution.PlusOne([9, 8, 9]));
  }

  [Fact]
  public void MaxProfitTest()
  {
    Assert.Equal(5, BestTimeToBuyAndSellStock.Solution.MaxProfit([7, 1, 5, 3, 6, 4]));
    Assert.Equal(0, BestTimeToBuyAndSellStock.Solution.MaxProfit([7, 6, 4, 3, 1]));
  }

  [Fact]
  public void IsPalindromeTest2()
  {
    Assert.True(ValidPalindrome.Solution.IsPalindrome("A man, a plan, a canal: Panama"));
    Assert.False(ValidPalindrome.Solution.IsPalindrome("race a car"));
    Assert.True(ValidPalindrome.Solution.IsPalindrome(" "));
    Assert.True(ValidPalindrome.Solution.IsPalindrome(".,"));
    Assert.True(ValidPalindrome.Solution.IsPalindrome("aa"));
  }

  [Fact]
  public void SingleNumberTest()
  {
    Assert.Equal(1, SingleNumber.Solution.SingleNumber([2, 2, 1]));
    Assert.Equal(4, SingleNumber.Solution.SingleNumber([4, 1, 2, 1, 2]));
    Assert.Equal(1, SingleNumber.Solution.SingleNumber([1]));
  }

  [Fact]
  public void ConvertToTitleTest()
  {
    Assert.Equal("A", ExcelSheetColumnTitle.Solution.ConvertToTitle(1));
    Assert.Equal("AB", ExcelSheetColumnTitle.Solution.ConvertToTitle(28));
    Assert.Equal("ZY", ExcelSheetColumnTitle.Solution.ConvertToTitle(701));
  }

  [Fact]
  public void MajorityElementTest()
  {
    Assert.Equal(3, MajorityElement.Solution.MajorityElement([3, 2, 3]));
    Assert.Equal(2, MajorityElement.Solution.MajorityElement([2, 2, 1, 1, 1, 2, 2]));
    Assert.Equal(3, MajorityElement.Solution.MajorityElement([1, 2, 3, 3, 3, 3, 4]));
  }

  [Fact]
  public void TitleToNumberTest()
  {
    Assert.Equal(1, ExcelSheetColumnNumber.Solution.TitleToNumber("A"));
    Assert.Equal(28, ExcelSheetColumnNumber.Solution.TitleToNumber("AB"));
    Assert.Equal(701, ExcelSheetColumnNumber.Solution.TitleToNumber("ZY"));
  }

  [Fact]
  public void ContainsDuplicateTest()
  {
    Assert.True(ContainsDuplicate.Solution.ContainsDuplicate([1, 2, 3, 1]));
    Assert.False(ContainsDuplicate.Solution.ContainsDuplicate([1, 2, 3, 4]));
    Assert.True(ContainsDuplicate.Solution.ContainsDuplicate([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]));
  }
}
