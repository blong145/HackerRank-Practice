using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank
{
	// https://www.hackerrank.com/challenges/insertionsort1
	public class Solution2
	{
		static void Main(String[] args)
		{
			int _ar_size;
			_ar_size = Convert.ToInt32(Console.ReadLine());
			int[] _ar = new int[_ar_size];
			String elements = Console.ReadLine();
			String[] split_elements = elements.Split(' ');
			for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
			{
				_ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
			}

			insertionSort(_ar);
		}

		public static int NumberOfSwaps { get; set; } //challenge for running time

		public static void insertionSort(int[] ar)
		{
			TestableInsertionSort(ar);
		}

		public static int[] TestableInsertionSort(int[] ar)
		{
			NumberOfSwaps = 0;
			for (int i = 0; i < ar.Length; i++)
			{
				ar = SwapToLeftUntilSorted(i, ar);
			}
			Console.WriteLine(NumberOfSwaps.ToString()); //challenge for running time
			return ar;
		}

		public static int[] SwapToLeftUntilSorted(int index, int[] input)
		{
			if (index == 0)
			{
				return input;
			}

			var currentNumber = input[index];
			var sortedArray = input;
			for (int i = index; i > 0; i--)
			{
				var numberToLeft = sortedArray[i - 1];
				if (currentNumber < numberToLeft)
				{
					//swap
					sortedArray[i - 1] = currentNumber;
					sortedArray[i] = numberToLeft;
					NumberOfSwaps++;
				}
				else if (currentNumber >= numberToLeft)
				{
					//break
					break;
				}
			}

			//Console.WriteLine(string.Join(" ", sortedArray));

			return sortedArray;
		}
	}
}


