namespace Kata.Strings.VowelCount;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        return str.Count(vowel => "aeiou".Contains(vowel));
    }
}
