using System.Collections.Generic;
using System.Text;

namespace ProgrammingTest.Algorithms
{
    public class Problem2
    {
        // The following assumptions are made for this problem:
        // 1. The input string can contain any character.
        // 2. Every character in the input string also appears somewhere in the sort order string.
        public static string SortLetters(string input, string sortOrder)
        {
            // Count the occurrences of each character in the input string using a dictionary
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                // Increment the count of the character if it already existed in the dictionary.
                if (charCount.TryGetValue(c, out int count))
                    charCount[c] = count + 1;

                // Add value to the dictionary if it doesn't exist.
                else
                    charCount[c] = 1;
            }

            // Build the result string based on the sort order and the character counts.
            StringBuilder result = new StringBuilder("", input.Length);

            foreach (char c in sortOrder)
            {
                if (charCount.ContainsKey(c))
                {
                    for (int i = 0; i < charCount[c]; i++)
                        result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
