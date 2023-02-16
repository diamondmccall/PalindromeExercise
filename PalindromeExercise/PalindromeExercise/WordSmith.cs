using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public bool IsPalindrome(string word)
		{
			var reversed = "";
			for (int i = word.Length - 1; i >= 0; i--) 
			{
				reversed += word[i];
			}
			if(word == reversed)
			{
				return true;
			}
			return false;
		}
	}
}

