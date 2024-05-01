namespace LengthOfLastWord;

public class Solution
{
  public static int LengthOfLastWord(string s)
  {
    string str = s.Trim();
    int count = 0;

    for (int i = str.Length - 1; i >= 0; i--)
    {
      if (str[i] != ' ')
      {
        count++;
      }
      else
      {
        break;
      }
    }

    return count;
  }

  public static void Test()
  {
    Console.WriteLine(LengthOfLastWord("Hello World"));
    // 5
    Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));
    // 4
    Console.WriteLine(LengthOfLastWord("luffy is still joyboy"));
    // 6
  }
}
