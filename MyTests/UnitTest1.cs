using FluentAssertions;
using GithubActionsPoc;

namespace MyTests;

public class UnitTest1
{
    [Fact]
    public void Success()
    {
        int res = MyClass.GetAnswer();
        res.Should().Be(42);
    }

    [Fact]
    public void Fail() 
    {
        42.Should().Be(73);
    }
}