using System;
using FluentAssertions;
using Xunit;

namespace FrameworkConsoleApp1.Tests.Story
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            true.Should().BeTrue();
        }
    }
}
