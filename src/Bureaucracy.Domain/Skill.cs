namespace Bureaucracy.Domain;

public sealed class Skill : ValueObject
{
    private readonly string _name;

    private Skill(string name) =>
        _name = name;

    public static Result<Skill, ErrorResult> Create(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return ErrorResult.Invalid(nameof(name));
        return new Skill(name);
    }

    public override string ToString() => _name;

    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return _name;
    }
}