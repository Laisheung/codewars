using NUnit.Framework;

namespace Codewars.RomanNumerals
{
	[TestFixture]
	public class RomanDecodeTests
	{
		[TestCase(1, "I")]
		[TestCase(4, "IV")]
		[TestCase(2008, "MMVIII")]
		[TestCase(1666, "MDCLXVI")]
		public void Test(int expected, string roman)
		{
			Assert.AreEqual(expected, RomanDecode.Solution(roman));
		}
	}

}