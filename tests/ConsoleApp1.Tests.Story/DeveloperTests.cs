using FluentAssertions;

namespace ConsoleApp1.Tests.Story;

public class DeveloperTests
{
    [Fact(DisplayName = "Тест разработчика")]
    public void Test1()
    {
        true.Should().BeTrue();
    }
}