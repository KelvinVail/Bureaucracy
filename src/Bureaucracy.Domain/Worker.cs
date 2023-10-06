namespace Bureaucracy.Domain;

public class Worker : Entity<Guid>
{
    private readonly string _name;

    private Worker(string name) =>
        _name = name;

    public static Worker Create(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));
        return new Worker(name) { Id = Guid.NewGuid() };
    }
}