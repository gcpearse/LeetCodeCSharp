namespace LeetCodeCSharp.Easy;

public class DetectCapitalSolution
{
  public static bool DetectCapitalUse(string word)
  {
    if (word.All(char.IsUpper)) return true;
    if (word.All(char.IsLower)) return true;
    if (word == char.ToUpper(word[0]) + word[1..].ToLower()) return true;

    return false;
  }
}


/*

We define the usage of capitals in a word to be right when one of the following cases holds:

All letters in this word are capitals, like "USA".
All letters in this word are not capitals, like "leetcode".
Only the first letter in this word is capital, like "Google".
Given a string word, return true if the usage of capitals in it is right.

Example 1:

Input: word = "USA"
Output: true

Example 2:

Input: word = "FlaG"
Output: false

*/
