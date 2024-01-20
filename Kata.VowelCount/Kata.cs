using System.Linq;

namespace Kata.VowelCount;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        return str.Count(vowel => "aeiou".Contains(vowel));
    }
}
