using System;

namespace Palindrome.Models
{
  public class PalindromeChecker
  {
    public static string UserInput { get; set; }
    public static bool IsPalindrome(string userInput)
    {
      UserInput = userInput;
      return true;
    }
  }
}

