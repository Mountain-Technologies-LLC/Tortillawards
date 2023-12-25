namespace Tortillawards.Data;

public class Ballot : AuditableEntity
{
    public required string Name { get; set; }
    public List<Award> Awards { get; set; } = [];
}

public class Award : Entity
{
    public required string Name { get; set; }
    public List<Nomination> Nominations { get; set; } = [];
}

public class Nomination : Entity
{
    public required string Name { get; set; }
    public List<Vote> Votes { get; set; } = [];
}

public class Vote : AuditableEntity
{
}

public abstract class Entity
{
    public int Id { get; set; }
}

public abstract class AuditableEntity : Entity
{
    public required ApplicationUser CreatedBy { get; set; }
}