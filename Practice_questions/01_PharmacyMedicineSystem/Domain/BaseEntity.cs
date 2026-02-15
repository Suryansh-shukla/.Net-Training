namespace Domain
{
    public abstract class BaseEntity
    {
        public required string Id { get; set; }

        public abstract void Validate(); // TODO: Implement validation
    }
}
