using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome.Models;
using System;

namespace Palindrome.TestTools
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_TakesUserInput_Bool()
    {
      string wordInput = "level";
      bool result = PalindromeChecker.IsPalindrome(wordInput);
      Assert.IsTrue(result);
    }
  }
}