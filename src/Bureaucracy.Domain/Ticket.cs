namespace Bureaucracy.Domain;

public class Ticket
{
    private Ticket()
    {
        Id = Guid.NewGuid();
    }

    public static Ticket Create()
    {
        return new Ticket();
    }

    public Guid Id { get; }
}