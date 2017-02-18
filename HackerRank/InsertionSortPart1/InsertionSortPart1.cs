using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRank
{
	// https://www.hackerrank.com/challenges/insertionsort1
	public class Solution
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

		public static void insertionSort(int[] ar)
		{
			ActualInsertionSort(ar);
			Console.WriteLine(string.Join(" ", ar));
		}

		public static int[] ActualInsertionSort(int[] input)
		{
			var unsortedValue = input[input.Length - 1];
			var sortedArray = input;
			for (int i = input.Length - 1; i >= 0; i--)
			{
				sortedArray = ShiftRight(i, sortedArray);

				if (unsortedValue > sortedArray[i] || i == 0)
				{
					sortedArray[i] = unsortedValue;
					return sortedArray;
				}

				Console.WriteLine(string.Join(" ", sortedArray));
			}

			return sortedArray;
		}

		public static int[] ShiftRight(int index, int[] input)
		{
			var shiftedArray = input;

			if (index > 0)
			{
				shiftedArray[index] = shiftedArray[index - 1];
			}
			return shiftedArray;
		}
	}
}


