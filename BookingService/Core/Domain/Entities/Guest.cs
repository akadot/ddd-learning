using Domain.ValueObjects;

namespace Domain;

public class Guest : Base
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Email { get; set; } = null!;
    public PersonId DocumentId {get;set;} = null!;
}
