using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars.MultiplesOf3or5.Tests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(23, Kata.Solution(10));
            Assert.AreEqual(258, Kata.Solution(34));
            Assert.AreEqual(0, Kata.Solution(-34));
        }
    }
}
