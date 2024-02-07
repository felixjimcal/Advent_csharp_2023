using challenges;

namespace ChallengesTests
{
    [TestClass]
    public class TwoTests
    {
        [TestMethod]
        public void TestRunWithMatchingWords()
        {
            List<string> words = ["tren", "oso", "pelota"];
            string letters = "tronesa";
            List<string> result = Two.Run(words, letters);

            CollectionAssert.AreEquivalent(new List<string> { "tren", "oso" }, result);
        }

        [TestMethod]
        public void TestRunWithNoMatchingWords()
        {
            List<string> words = ["gato", "perro"];
            string letters = "tronesa";
            List<string> result = Two.Run(words, letters);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void TestRunWithAllMatchingWords()
        {
            List<string> words = ["tren", "oso", "nota"];
            string letters = "tronesa";
            List<string> result = Two.Run(words, letters);

            CollectionAssert.AreEquivalent(words, result);
        }
    }
}