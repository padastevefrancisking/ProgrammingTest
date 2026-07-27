using ProgrammingTest.Algorithms;

namespace ProgrammingTest.Tests
{
    public class Problem2Tests
    {
        [Test]
        public void SortLetters_ShouldReturnSortedString_WhenInputIsValid_1()
        {
            string input = "hello world";
            string sortOrder = "abcdefghijklmnopqrstuvwxyz ";
            string expected = "dehllloorw ";
            string result = Problem2.SortLetters(input, sortOrder);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void SortLetters_ShouldReturnSortedString_WhenInputIsValid_2()
        {
            string input = "Programming is fun!";
            string sortOrder = "!nsiPomf ragu";
            string expected = "!nnsiiPommf  rraggu";
            string result = Problem2.SortLetters(input, sortOrder);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void SortLetters_ShouldReturnSortedString_WhenInputIsValid_3()
        {
            string input = "trion world network";
            string sortOrder = " oinewkrtdl";
            string expected = "  oooinnewwkrrrttdl";
            string result = Problem2.SortLetters(input, sortOrder);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void SortLetters_ShouldReturnEmptyString_WhenInputIsEmpty()
        {
            string input = "";
            string sortOrder = "abcdefghijklmnopqrstuvwxyz ";
            string expected = "";
            string result = Problem2.SortLetters(input, sortOrder);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void SortLetters_ShouldReturnEmptyString_WhenInputAndSortOrderAreEmpty()
        {
            string input = "";
            string sortOrder = "";
            string expected = "";
            string result = Problem2.SortLetters(input, sortOrder);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void SortLetters_ShouldReturnSortedString_WhenInputHasSpecialCharacters()
        {
            string input = "Hello, World!";
            string sortOrder = " !,HWdlore";
            string expected = " !,HWdllloore";
            string result = Problem2.SortLetters(input, sortOrder);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
