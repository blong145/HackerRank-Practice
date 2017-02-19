using NUnit.Framework;

namespace HackerRank.Tests
{
	[TestFixture]
	public class InsertionSortPart2Tests
	{
		[Test]
		public void ShouldSortAnUnorderedListOfSize1()
		{
			//arrange 
			var unorderedList = new[] { 1 };
			//act
			var sortedList = Solution2.TestableInsertionSort(unorderedList);
			//assert
			CollectionAssert.IsOrdered(sortedList);
		}

		[Test]
		public void ShouldSortAnUnorderedListOfSize2()
		{
			//arrange 
			var unorderedList = new[] { 2, 1 };
			//act
			var sortedList = Solution2.TestableInsertionSort(unorderedList);
			//assert
			CollectionAssert.IsOrdered(sortedList);
		}

		[Test]
		public void ShouldSortAnUnorderedListOfSize3()
		{
			//arrange 
			var unorderedList = new[] { 2, 1, 6 };
			//act
			var sortedList = Solution2.TestableInsertionSort(unorderedList);
			//assert
			CollectionAssert.IsOrdered(sortedList);
		}

		[Test]
		public void ShouldSortAnUnorderedListOfSmallSize()
		{
			//arrange 
			var unorderedList = new[] { 13, 51, 12, 15,2,3,5,4,23,42, 7, 191 };
			//act
			var sortedList = Solution2.TestableInsertionSort(unorderedList);
			//assert
			CollectionAssert.AreEqual(new []{2,3,4,5,7,12,13,15,23,42,51,191}, sortedList);
		}

		[Test]
		public void ShouldSortAnUnorderedListWithFirstElementCorrect()
		{
			//arrange 
			var unorderedList = new[] { 1, 51, 12, 15, 2, 13, 5, 4, 23, 42, 7, 191 };
			//act
			var sortedList = Solution2.TestableInsertionSort(unorderedList);
			//assert
			CollectionAssert.AreEqual(new[] { 1, 2, 4, 5, 7, 12, 13, 15, 23, 42, 51, 191 }, sortedList);
		}
	}
}