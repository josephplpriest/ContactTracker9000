namespace ContactTracker.Domain.Contacts
{
     public interface IContactRepository
    {
        Task<Contact> GetAsync(Guid id);

        Task<IEnumerable<Contact>> ListAsync();

        Task AddAsync(Contact c);

        Task DeleteAsync(Guid id);

        void Update(Contact c);

        Task SaveChangesAsync();
    }
}

