using System.Linq;

namespace Kata.VowelCount;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        string[] vowels = ["a", "e", "i", "o", "u"];

        vowelCount = str.Where(x => vowels.Contains(x.ToString())).Count();

        return vowelCount;
    }
}
