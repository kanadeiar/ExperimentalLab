using FluentAssertions;
using Xunit;

namespace FrameworkConsoleApp1.Tests.Story
{
    public class DeveloperTests
    {
        [Fact(DisplayName = "Тест разработчика")]
        public void TestMethod1()
        {
            true.Should().BeTrue();
        }
    }
}
