using challenges;

namespace ChallengesTests
{
    [TestClass]
    public class FourTests
    {
        [TestMethod]
        public void TestSimpleInvert()
        {
            string result = Four.Run("hola (odnum)");
            Assert.AreEqual("hola mundo", result);
        }

        [TestMethod]
        public void TestNestedInvert()
        {
            string result = Four.Run("sa(u(cla)atn)s");
            Assert.AreEqual("santaclaus", result);
        }

        [TestMethod]
        public void TestMultipleInvert()
        {
            string result = Four.Run("(olleh) (dlrow)!");
            Assert.AreEqual("hello world!", result);
        }

        [TestMethod]
        public void TestNoParentheses()
        {
            string result = Four.Run("hello world");
            Assert.AreEqual("hello world", result);
        }

        [TestMethod]
        public void TestEmptyString()
        {
            string result = Four.Run("");
            Assert.AreEqual("", result);
        }
    }
}