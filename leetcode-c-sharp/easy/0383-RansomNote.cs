namespace RansomNote;

public class Solution
{
  public static bool CanConstruct(string ransomNote, string magazine)
  {
    List<char> chars = new(ransomNote);

    foreach (char c in magazine)
    {
      chars.Remove(c);
    }

    return chars.Count == 0;
  }

  public static void Test()
  {
    Console.WriteLine(CanConstruct("a", "b"));
    // False
    Console.WriteLine(CanConstruct("aa", "ab"));
    // False
    Console.WriteLine(CanConstruct("aa", "aab"));
    // True
    Console.WriteLine(CanConstruct("bg", "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj"));
    // True
  }
}


/*

Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

Example 1:

Input: ransomNote = "a", magazine = "b"
Output: false

Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false

Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true

*/
