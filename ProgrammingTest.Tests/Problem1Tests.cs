using ProgrammingTest.Algorithms;

namespace ProgrammingTest.Tests
{
    public class Problem1Tests
    {
        [Test]
        public void AllDigitsUnique_ShouldReturnTrue_WhenAllDigitsAreUnique_1()
        {
            uint input = 17308459;
            bool result = Problem1.AllDigitsUnique(input);
            Assert.IsTrue(result);
        }

        [Test]
        public void AllDigitsUnique_ShouldReturnTrue_WhenAllDigitsAreUnique_2()
        {
            uint input = 3259607814;
            bool result = Problem1.AllDigitsUnique(input);
            Assert.IsTrue(result);
        }

        [Test]
        public void AllDigitsUnique_ShouldReturnFalse_WhenDigitsAreNotUnique_1()
        {
            uint input = 48778584;
            bool result = Problem1.AllDigitsUnique(input);
            Assert.IsFalse(result);
        }

        [Test]
        public void AllDigitsUnique_ShouldReturnFalse_WhenDigitsAreNotUnique_2()
        {
            uint input = 1234567891;
            bool result = Problem1.AllDigitsUnique(input);
            Assert.IsFalse(result);
        }

        [Test]
        public void AllDigitsUnique_ShouldReturnTrue_WhenInputIsSingleDigit()
        {
            uint input = 7;
            bool result = Problem1.AllDigitsUnique(input);
            Assert.IsTrue(result);
        }

        [Test]
        public void AllDigitUnique_ShouldReturnTrue_WhenInputIsZero()
        {
            uint input = 0;
            bool result = Problem1.AllDigitsUnique(input);
            Assert.IsTrue(result);
        }
    }
}
