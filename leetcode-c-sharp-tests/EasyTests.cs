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

  [Fact]
  public void IsPowerOfTwoTest()
  {
    Assert.True(IsPowerOfTwo.Solution.IsPowerOfTwo(1));
    Assert.True(IsPowerOfTwo.Solution.IsPowerOfTwo(8));
    Assert.True(IsPowerOfTwo.Solution.IsPowerOfTwo(16));
    Assert.False(IsPowerOfTwo.Solution.IsPowerOfTwo(3));
  }

  [Fact]
  public void IsAnagramTest()
  {
    Assert.True(ValidAnagram.Solution.IsAnagram("anagram", "nagaram"));
    Assert.False(ValidAnagram.Solution.IsAnagram("rat", "car"));
    Assert.False(ValidAnagram.Solution.IsAnagram("ac", "bb"));
  }

  [Fact]
  public void AddDigitsTest()
  {
    Assert.Equal(2, AddDigits.Solution.AddDigits(38));
    Assert.Equal(0, AddDigits.Solution.AddDigits(0));
  }

  [Fact]
  public void MissingNumberTest()
  {
    Assert.Equal(2, MissingNumber.Solution.MissingNumber([3, 0, 1]));
    Assert.Equal(2, MissingNumber.Solution.MissingNumber([0, 1]));
    Assert.Equal(8, MissingNumber.Solution.MissingNumber([9, 6, 4, 2, 3, 5, 7, 0, 1]));
  }

  [Fact]
  public void WordPatternTest()
  {
    Assert.True(WordPattern.Solution.WordPattern("abba", "dog cat cat dog"));
    Assert.False(WordPattern.Solution.WordPattern("abba", "dog cat cat fish"));
    Assert.False(WordPattern.Solution.WordPattern("aaaa", "dog cat cat dog"));
    Assert.False(WordPattern.Solution.WordPattern("abba", "dog dog dog dog"));
  }

  [Fact]
  public void IsPowerOfThreeTest()
  {
    Assert.True(PowerOfThree.Solution.IsPowerOfThree(27));
    Assert.False(PowerOfThree.Solution.IsPowerOfThree(0));
    Assert.False(PowerOfThree.Solution.IsPowerOfThree(-1));
  }

  [Fact]
  public void IsPowerOfFourTest()
  {
    Assert.True(PowerOfFour.Solution.IsPowerOfFour(16));
    Assert.False(PowerOfFour.Solution.IsPowerOfFour(5));
    Assert.True(PowerOfFour.Solution.IsPowerOfFour(1));
  }

  [Fact]
  public void ReverseVowelsTest()
  {
    Assert.Equal("holle", ReverseVowelsOfString.Solution.ReverseVowels("hello"));
    Assert.Equal("leotcede", ReverseVowelsOfString.Solution.ReverseVowels("leetcode"));
  }

  [Fact]
  public void IntersectionTest()
  {
    Assert.Equal([2], IntersectionOfTwoArrays.Solution.Intersection([1, 2, 2, 1], [2, 2]));
    Assert.Equal([4, 9], IntersectionOfTwoArrays.Solution.Intersection([4, 9, 5], [9, 4, 9, 8, 4]));
  }

  [Fact]
  public void IsPerfectSquareTest()
  {
    Assert.True(ValidPerfectSquare.Solution.IsPerfectSquare(16));
    Assert.False(ValidPerfectSquare.Solution.IsPerfectSquare(14));
  }

  [Fact]
  public void CanConstructTest()
  {
    Assert.False(RansomNote.Solution.CanConstruct("a", "b"));
    Assert.False(RansomNote.Solution.CanConstruct("aa", "ab"));
    Assert.True(RansomNote.Solution.CanConstruct("aa", "aab"));
    Assert.True(RansomNote.Solution.CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"));
  }

  [Fact]
  public void FirstUniqCharTest()
  {
    Assert.Equal(0, FirstUniqueCharacterInString.Solution.FirstUniqChar("leetcode"));
    Assert.Equal(2, FirstUniqueCharacterInString.Solution.FirstUniqChar("loveleetcode"));
    Assert.Equal(-1, FirstUniqueCharacterInString.Solution.FirstUniqChar("aabb"));
  }

  [Fact]
  public void FindTheDifferenceTest()
  {
    Assert.Equal('e', FindTheDifference.Solution.FindTheDifference("abcd", "abcde"));
    Assert.Equal('y', FindTheDifference.Solution.FindTheDifference("", "y"));
  }

  [Fact]
  public void IsSubsequenceTest()
  {
    Assert.True(IsSubsequence.Solution.IsSubsequence("abc", "ahbgdc"));
    Assert.False(IsSubsequence.Solution.IsSubsequence("axc", "ahbgdc"));
    Assert.False(IsSubsequence.Solution.IsSubsequence("acb", "ahbgdc"));
    Assert.True(IsSubsequence.Solution.IsSubsequence("b", "abc"));
  }

  [Fact]
  public void LongestPalindromeTest()
  {
    Assert.Equal(7, LongestPalindrome.Solution.LongestPalindrome("abccccdd"));
    Assert.Equal(1, LongestPalindrome.Solution.LongestPalindrome("a"));
  }

  [Fact]
  public void FizzBuzzTest()
  {
    Assert.Equal(["1", "2", "Fizz"], FizzBuzz.Solution.FizzBuzz(3));
    Assert.Equal(["1", "2", "Fizz", "4", "Buzz"], FizzBuzz.Solution.FizzBuzz(5));
    Assert.Equal(["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"], FizzBuzz.Solution.FizzBuzz(15));
  }

  [Fact]
  public void ThirdMaxTest()
  {
    Assert.Equal(1, ThirdMaximumNumber.Solution.ThirdMax([3, 2, 1]));
    Assert.Equal(2, ThirdMaximumNumber.Solution.ThirdMax([1, 2]));
    Assert.Equal(1, ThirdMaximumNumber.Solution.ThirdMax([2, 2, 3, 1]));
  }

  [Fact]
  public void CountSegmentsTest()
  {
    Assert.Equal(5, NumberOfSegmentsInString.Solution.CountSegments("Hello, my name is John"));
    Assert.Equal(1, NumberOfSegmentsInString.Solution.CountSegments("Hello"));
    Assert.Equal(0, NumberOfSegmentsInString.Solution.CountSegments(""));
  }

  [Fact]
  public void ArrangeCoinsTest()
  {
    Assert.Equal(2, ArrangingCoins.Solution.ArrangeCoins(5));
    Assert.Equal(3, ArrangingCoins.Solution.ArrangeCoins(8));
    Assert.Equal(1, ArrangingCoins.Solution.ArrangeCoins(1));
  }

  [Fact]
  public void FindDisappearedNumbersTest()
  {
    Assert.Equal([5, 6], FindAllNumbersDisappearedInAnArray.Solution.FindDisappearedNumbers([4, 3, 2, 7, 8, 2, 3, 1]));
    Assert.Equal([2], FindAllNumbersDisappearedInAnArray.Solution.FindDisappearedNumbers([1, 1]));
  }

  [Fact]
  public void FindContentChildrenTest()
  {
    Assert.Equal(1, AssignCookies.Solution.FindContentChildren([1, 2, 3], [1, 1]));
    Assert.Equal(2, AssignCookies.Solution.FindContentChildren([1, 2], [1, 2, 3]));
  }
}
