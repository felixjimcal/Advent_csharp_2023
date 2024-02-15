using challenges;

namespace ChallengesTests
{
    [TestClass]
    public class ThreeTests
    {
        [TestMethod]
        public void TestRunWithExtraCharAtEnd()
        {
            string result = Three.Run("abc", "abcd");
            Assert.AreEqual("d", result);
        }

        [TestMethod]
        public void TestRunWithExtraCharAtStart()
        {
            string result = Three.Run("abc", "zabc");
            Assert.AreEqual("z", result);
        }

        [TestMethod]
        public void TestRunWithExtraCharInMiddle()
        {
            string result = Three.Run("abc", "abxc");
            Assert.AreEqual("x", result);
        }

        [TestMethod]
        public void TestRunWithNoExtraChar()
        {
            string result = Three.Run("abc", "abc");
            Assert.AreEqual("", result);
        }
    }
}