using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HackerRank
{
	public class Solution3
	{

		static void Main(String[] args)
		{
			string[] tokens_m = Console.ReadLine().Split(' ');
			int m = Convert.ToInt32(tokens_m[0]);
			int n = Convert.ToInt32(tokens_m[1]);
			string[] magazine = Console.ReadLine().Split(' ');
			string[] ransom = Console.ReadLine().Split(' ');
		}

		public bool IsRansomNotePossible(string[] possibleWords, string[] ransomNoteWords)
		{
			//wrong...lol
			foreach (var ransomNoteWord in ransomNoteWords)
			{
				if (possibleWords.Contains(ransomNoteWord) == false)
				{
					return false;
				}
			}

			return true;
		}
	}
}
