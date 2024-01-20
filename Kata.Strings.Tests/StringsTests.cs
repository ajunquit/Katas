namespace Kata.Strings;

[TestFixture]
public class StringsTests
{
    [Test]
    public void Test_VowelCount()
    {
        int vowelsCount = VowelCount.Kata.GetVowelCount("abracadabra");
        int expectedValue = 5;
        Assert.That(expectedValue, Is.EqualTo(vowelsCount));
    }
}