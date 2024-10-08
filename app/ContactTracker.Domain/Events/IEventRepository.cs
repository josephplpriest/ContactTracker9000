namespace ContactTracker.Domain.Events
{
    public interface IEventRepository
    {
        internal protected Task<Event> GetAsync(Guid id);

        internal protected Task<IEnumerable<Event>> ListAsync();

        internal protected Task AddAsync(Event e);

        internal protected void Update(Event e);

        internal protected Task DeleteAsync(Guid id);

        internal protected Task SaveChangesAsync();
    }
}