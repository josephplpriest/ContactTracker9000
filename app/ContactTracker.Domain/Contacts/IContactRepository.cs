namespace ContactTracker.Domain.Contacts
{
     public interface IContactRepository
    {
        internal protected Task<Contact> GetAsync(Guid id);

        internal protected Task<IEnumerable<Contact>> ListAsync();

        internal protected Task AddAsync(Contact c);

        internal protected Task DeleteAsync(Guid id);

        internal protected void Update(Contact c);

        internal protected Task SaveChangesAsync();
    }
}

