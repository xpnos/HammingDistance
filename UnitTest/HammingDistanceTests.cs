using HBL = BL.HammingBL;

namespace HammingBL.Tests
{
    [TestFixture()]
    public class HammingDistanceTests
    {
        [Test]
        [TestCase("", "", ExpectedResult = 0)]
        [TestCase("a", "a", ExpectedResult = 0)]
        [TestCase("🙂", "🙂", ExpectedResult = 0)]
        [TestCase("cab", "cab", ExpectedResult = 0)]
        [TestCase("cab", "Cab", ExpectedResult = 1)]
        [TestCase("duck", "buck", ExpectedResult = 1)]
        [TestCase("gold", "blue", ExpectedResult = 4)]
        public int NoErrors(string A, String B)
        {
            return HBL.HammingDistance(A, B);
        }

        [Test]
        public void NullBoth() 
        {
            string expectedMsg = "Value cannot be null. (Parameter 'A')";
            var ex = Assert.Throws<ArgumentNullException>(delegate { HBL.HammingDistance(null, null); });

                Assert.That(ex.Message.ToLowerInvariant(), Does.Contain(expectedMsg.ToLowerInvariant()), message: $"Description mismatch. Expected: {expectedMsg} but was: {ex.Message}");
        }

        [Test]
        public void NullA()
        {
            string expectedMsg = "Value cannot be null. (Parameter 'A')";
            var ex = Assert.Throws<ArgumentNullException>(delegate { HBL.HammingDistance(null, "HI"); });

            Assert.That(ex.Message.ToLowerInvariant(), Does.Contain(expectedMsg.ToLowerInvariant()), message: $"Description mismatch. Expected: {expectedMsg} but was: {ex.Message}");
        }

        [Test]
        public void NullB()
        {
            string expectedMsg = "Value cannot be null. (Parameter 'B')";
            var ex = Assert.Throws<ArgumentNullException>(delegate { HBL.HammingDistance("HI", null); });

            Assert.That(ex.Message.ToLowerInvariant(), Does.Contain(expectedMsg.ToLowerInvariant()), message: $"Description mismatch. Expected: {expectedMsg} but was: {ex.Message}");
        }
    }
}