using challenges;

namespace ChallengesTests
{
    [TestClass]
    public class OneTests
    {
        [TestMethod]
        public void TestRunWithDuplicateNumber()
        {
            int result = One.Run([1, 2, 3, 4, 5, 3]);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestRunWithNoDuplicate()
        {
            int result = One.Run([1, 2, 3, 4, 5]);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestRunWithMultipleDuplicates()
        {
            int result = One.Run([1, 2, 2, 3, 3]);
            Assert.AreEqual(2, result);
        }
    }
}