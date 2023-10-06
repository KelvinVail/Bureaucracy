namespace Bureaucracy.Domain.Tests;

public class SkillTests
{
    [Fact]
    public void NameMustNotBeNull()
    {
        var result = Skill.Create(null!);

        result.ShouldBeFailure(ErrorResult.Invalid("name"));
    }

    [Fact]
    public void NameMustNotBeEmpty()
    {
        var result = Skill.Create(string.Empty);

        result.ShouldBeFailure(ErrorResult.Invalid("name"));
    }

    [Fact]
    public void NameMustNotBeWithSpace()
    {
        var result = Skill.Create(" ");

        result.ShouldBeFailure(ErrorResult.Invalid("name"));
    }

    [Fact]
    public void TwoSkillsWithTheSameNameAreEqual()
    {
        var skill1 = Skill.Create("Developer").Value;
        var skill2 = Skill.Create("Developer").Value;

        skill1.Should().BeRankedEquallyTo(skill2);
    }

    [Fact]
    public void TwoSkillsWithDifferentNamesAreNotEqual()
    {
        var skill1 = Skill.Create("Developer").Value;
        var skill2 = Skill.Create("Tester").Value;

        skill1.Should().NotBeRankedEquallyTo(skill2);
    }

    [Theory]
    [InlineData("Developer")]
    [InlineData("Tester")]
    public void ToStringReturnsTheSkillName(string name)
    {
        var skill = Skill.Create(name).Value;

        skill.ToString().Should().Be(name);
    }
}