namespace ContactTracker.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public string CreatedBy { get; set; } = "System";

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    }
}