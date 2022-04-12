namespace Bureaucracy.Domain;

public class Worker
{
    private readonly string _name;

    private Worker(string name) =>
        _name = name;

    public static Worker CreateSoftwareEngineer(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));
        return new Worker(name);
    }
}