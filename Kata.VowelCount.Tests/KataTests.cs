using System;
using NUnit.Framework;

namespace Kata.VowelCount.Tests;

[TestFixture]
public class KataTests
{
    [Test]
    public void TestCase1()
    {
        Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"));
    }
}