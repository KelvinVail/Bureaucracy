namespace Bureaucracy.Domain.Tests;

public class WorkerTests
{
    [Fact]
    public void NameMustNotBeNull()
    {
        var ex = Assert.Throws<ArgumentNullException>(() => Worker.Create(null));
        Assert.Equal("name", ex.ParamName);
    }

    [Fact]
    public void NameMustNotBeEmpty()
    {
        var ex = Assert.Throws<ArgumentNullException>(() => Worker.Create(string.Empty));
        Assert.Equal("name", ex.ParamName);
    }

    [Fact]
    public void NameMustNotBeWhitespace()
    {
        var ex = Assert.Throws<ArgumentNullException>(() => Worker.Create(" "));
        Assert.Equal("name", ex.ParamName);
    }
}