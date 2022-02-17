using ComputerScience;
using NUnit.Framework;

namespace ComputerScienceTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Assert.Pass();
        Assert.That(new Class1().HelloWorld(), Is.EqualTo("Hello World"));
    }
}
