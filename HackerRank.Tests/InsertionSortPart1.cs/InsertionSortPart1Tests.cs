using NUnit.Framework;
using System;
namespace HackerRank.Tests
{
	[TestFixture()]
	public class WhenShiftingRight
	{
		[Test()]
		public void ShouldCopyTheSecondToLastElementToTheLastPlace()
		{
			//arrange
			var arranged = new[] { 2, 4, 6, 8, 3 };
			//act
			var result = Solution.ShiftRight(4, arranged);

			//assert
			CollectionAssert.AreEqual(new[] { 2, 4, 6, 8, 8 }, result);
		}

		[Test()]
		public void ShouldCopyTheThirdToLastElementToTheSecondToLastPlace()
		{
			//arrange
			var insertionSortPart1 = new Solution();
			var arranged = new[] { 2, 4, 6, 8, 8 };
			//act
			var result = Solution.ShiftRight(3, arranged);

			//assert
			CollectionAssert.AreEqual(new[] { 2, 4, 6, 6, 8 }, result);
		}

		[Test()]
		public void ShouldDoNothingForTheFirstIndex()
		{
			//arrange
			var insertionSortPart1 = new Solution();
			var arranged = new[] { 2, 3, 4, 6, 8 };
			//act
			var result = Solution.ShiftRight(0, arranged);

			//assert
			CollectionAssert.AreEqual(new[] { 2, 3, 4, 6, 8 }, result);
		}
	}

	[TestFixture]
	public class WhenPerformingAnInsertionSort
	{
		[Test]
		public void ShouldReturnASortedListWhenTheUnorderedNumberExistsInTheMiddle()
		{
			//arrange
			var insertionSortPart1 = new Solution();
			var arranged = new[] { 2, 4, 6, 8, 3 };
			//act
			var result = Solution.ActualInsertionSort(arranged);

			//assert
			CollectionAssert.AreEqual(new[] { 2, 3, 4, 6, 8 }, result);
		}

		[Test]
		public void ShouldReturnASortedListWhenTheUnorderedNumberShouldBeFirst()
		{
			//arrange
			var insertionSortPart1 = new Solution();
			var arranged = new[] { 3, 4, 6, 8, 1 };
			//act
			var result = Solution.ActualInsertionSort(arranged);

			//assert
			CollectionAssert.AreEqual(new[] { 1, 3, 4, 6, 8 }, result);
		}

		[Test]
		public void ShouldReturnASortedListWhenTheUnorderedNumberIsLast()
		{
			//arrange
			var insertionSortPart1 = new Solution();
			var arranged = new[] { 3, 4, 6, 8, 9 };
			//act
			var result = Solution.ActualInsertionSort(arranged);

			//assert
			CollectionAssert.AreEqual(new[] {3, 4, 6, 8, 9 }, result);
		}
	}
}
