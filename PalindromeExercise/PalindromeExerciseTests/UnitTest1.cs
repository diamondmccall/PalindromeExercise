using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hi", false)]

        public void MyTesting(string word, bool expected)
        {
            var palindrome = new WordSmith();

            var actual = palindrome.IsPalindrome(word);

            Assert.Equal(expected,actual);
        }
    }
}
