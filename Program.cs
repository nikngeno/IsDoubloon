namespace IsDoubloon
{
    public class DoubloonChecker
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word to check:");
            string word = Console.ReadLine();

            if (IsDoubloon(word))
            {
                Console.WriteLine("\"{0}\" is a doubloon!", word);
            }
            else
            {
                Console.WriteLine("\"{0}\" is not a doubloon.", word);
            }
        }
    public static bool IsDoubloon(string word)
        {
            var charCounts = new int[26];

            // Count the occurrences of each letter
            foreach (char c in word)
            {
                charCounts[c - 'a']++;
            }

            // Check if each letter appears exactly twice
            foreach (var count in charCounts)
            {
                if (count != 0 && count != 2)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
