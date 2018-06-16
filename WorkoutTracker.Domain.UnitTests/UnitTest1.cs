using NUnit.Framework;
using FluentAssertions;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_The_Test()
        {
            true.Should().BeTrue();
        }
    }
}