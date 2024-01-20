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

    [Test]
    public void Test_GroupedByCommas()
    {
        Assert.That(GroupedByCommas.Kata.GroupByCommas(1), Is.EqualTo("1"));
        Assert.That(GroupedByCommas.Kata.GroupByCommas(12), Is.EqualTo("12"));
        Assert.That(GroupedByCommas.Kata.GroupByCommas(123), Is.EqualTo("123"));
        Assert.That(GroupedByCommas.Kata.GroupByCommas(1234), Is.EqualTo("1,234"));
        Assert.That(GroupedByCommas.Kata.GroupByCommas(12345), Is.EqualTo("12,345"));
        Assert.That(GroupedByCommas.Kata.GroupByCommas(123456), Is.EqualTo("123,456"));
        Assert.That(GroupedByCommas.Kata.GroupByCommas(1234567), Is.EqualTo("1,234,567"));
        Assert.That(GroupedByCommas.Kata.GroupByCommas(12345678), Is.EqualTo("12,345,678"));
        Assert.That(GroupedByCommas.Kata.GroupByCommas(123456789), Is.EqualTo("123,456,789"));
        Assert.That(GroupedByCommas.Kata.GroupByCommas(1234567890), Is.EqualTo("1,234,567,890"));
    }
}