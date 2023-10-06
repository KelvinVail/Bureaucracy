namespace Bureaucracy.Domain;

public sealed class Task : Entity<Guid>
{
    private Task()
    {
    }

    public static Result<Task, ErrorResult> Create(
        string name,
        Skill skill,
        long hourEstimate)
    {
        if (string.IsNullOrWhiteSpace(name))
            return ErrorResult.Invalid(nameof(name));
        if (skill == null)
            return ErrorResult.Invalid(nameof(skill));
        if (hourEstimate <= 0)
            return ErrorResult.Invalid(nameof(hourEstimate), "must be positive.");

        return new Task { Id = Guid.NewGuid() };
    }
}