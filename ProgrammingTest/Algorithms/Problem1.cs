namespace ProgrammingTest.Algorithms
{
    public class Problem1
    {
        public static bool AllDigitsUnique(uint value)
        {
            // Each digit is represented by an index in the array.
            // Each element represents whether the digit has been seen or not.
            // Utilized an array instead of a hashmap to improve performance, as the range of digits is fixed (0-9).
            bool[] seen = new bool[10];

            do
            {
                // Get the last digit of the number
                int digit = (int)(value % 10);

                // If it has already been seen, return false
                if (seen[digit])
                    return false;

                // Set the seen value to true and proceed to the next number
                seen[digit] = true;
                value /= 10;
            } while (value > 0);

            // Returns true when no digits have been repeated in the number
            return true;
        }
    }
}
