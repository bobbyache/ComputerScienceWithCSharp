using ComputerScience;
using NUnit.Framework;

namespace ComputerScienceTests;

public class TestProblemTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Assert.Pass();
        Assert.That(new TestProblem().HelloWorld(), Is.EqualTo("Hello World"));
    }
}
