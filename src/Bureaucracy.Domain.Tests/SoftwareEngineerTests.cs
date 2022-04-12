using System;
using Xunit;

namespace Bureaucracy.Domain.Tests;

public class SoftwareEngineerTests
{
    [Fact]
    public void NameMustNotBeNull()
    {
        var ex = Assert.Throws<ArgumentNullException>(() => Worker.CreateSoftwareEngineer(null));
        Assert.Equal("name", ex.ParamName);
    }

    [Fact]
    public void NameMustNotBeEmpty()
    {
        var ex = Assert.Throws<ArgumentNullException>(() => Worker.CreateSoftwareEngineer(string.Empty));
        Assert.Equal("name", ex.ParamName);
    }

    [Fact]
    public void NameMustNotBeWhitespace()
    {
        var ex = Assert.Throws<ArgumentNullException>(() => Worker.CreateSoftwareEngineer(" "));
        Assert.Equal("name", ex.ParamName);
    }
}