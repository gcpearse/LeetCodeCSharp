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
}
