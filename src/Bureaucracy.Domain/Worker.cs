namespace Bureaucracy.Domain;

public sealed class Worker : Entity<Guid>
{
    private readonly string _name;

    private Worker(string name) =>
        _name = name;

    public static Result<Worker, ErrorResult> Create(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return ErrorResult.Invalid(nameof(name));
        return new Worker(name) { Id = Guid.NewGuid() };
    }
}