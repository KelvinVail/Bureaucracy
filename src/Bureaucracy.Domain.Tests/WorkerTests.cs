namespace Bureaucracy.Domain.Tests;

public class WorkerTests
{
    [Fact]
    public void NameMustNotBeNull()
    {
        var result = Worker.Create(null!);

        result.ShouldBeFailure(ErrorResult.Invalid("name"));
    }

    [Fact]
    public void NameMustNotBeEmpty()
    {
        var result = Worker.Create(string.Empty);

        result.ShouldBeFailure(ErrorResult.Invalid("name"));
    }

    [Fact]
    public void NameMustNotBeWhitespace()
    {
        var result = Worker.Create(" ");

        result.ShouldBeFailure(ErrorResult.Invalid("name"));
    }

    [Fact]
    public void IsCreatedWithAnId()
    {
        var result = Worker.Create("Jim");

        result.Value.Id.Should().NotBeEmpty();
    }

    [Fact]
    public void TwoWorkersWithTHeSameNameAreNotEqual()
    {
        var jim1 = Worker.Create("Jim").Value;
        var jim2 = Worker.Create("Jim").Value;

        jim1.Should().NotBeRankedEquallyTo(jim2);
    }
}