namespace Bureaucracy.Domain.Tests;

public class TaskTests
{
    [Fact]
    public void NameMustNotBeNull()
    {
        var result = Task.Create(null!, Skill.Create("skill").Value, 1);

        result.ShouldBeFailure(ErrorResult.Invalid("name"));
    }

    [Fact]
    public void NameMustNotBeEmpty()
    {
        var result = Task.Create(string.Empty, Skill.Create("skill").Value, 1);

        result.ShouldBeFailure(ErrorResult.Invalid("name"));
    }

    [Fact]
    public void NameMustNotBeWhiteSpace()
    {
        var result = Task.Create(" ", Skill.Create("skill").Value, 1);

        result.ShouldBeFailure(ErrorResult.Invalid("name"));
    }

    [Fact]
    public void SkillMustNotBeNull()
    {
        var result = Task.Create("name", null!, 1);

        result.ShouldBeFailure(ErrorResult.Invalid("skill"));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-27)]
    public void HourEstimateMustBePositive(long hourEstimate)
    {
        var result = Task.Create("name", Skill.Create("skill").Value, hourEstimate);

        result.ShouldBeFailure(
            ErrorResult.Invalid(nameof(hourEstimate), "must be positive."));
    }

    [Fact]
    public void IdMustNotBeEmpty()
    {
        var task = Task.Create("name", Skill.Create("skill").Value, 1).Value;

        task.Id.Should().NotBeEmpty();
    }
}