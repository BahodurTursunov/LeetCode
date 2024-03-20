using System.Text;

namespace Merge_Strings_Alternately;

public class Program {
    static void Main(string[] args)
    {
        string word1 = "abc";
        string word2 = "pqr";
        Console.WriteLine(MergeAlternately(word1, word2)); // Output: "apbqcr"

        word1 = "ab";
        word2 = "pqrs";
        Console.WriteLine(MergeAlternately(word1, word2)); // Output: "apbqrs"

        word1 = "abcd";
        word2 = "pq";
        Console.WriteLine(MergeAlternately(word1, word2));
    }
    static string MergeAlternately(string word1, string word2)
    {
        StringBuilder merged = new StringBuilder();
        int maxLength = Math.Max(word1.Length, word2.Length);

        for (int i = 0; i < maxLength; i++)
        {
            if (i < word1.Length)
                merged.Append(word1[i]);
            if (i < word2.Length)
                merged.Append(word2[i]);
        }

        return merged.ToString();
    }
}