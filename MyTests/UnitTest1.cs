using FluentAssertions;
using GithubActionsPoc;

namespace MyTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int res = MyClass.GetAnswer();
        res.Should().Be(42);
    }
}