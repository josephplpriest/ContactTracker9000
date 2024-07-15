using ContactTracker.Domain.Contacts;
using Microsoft.EntityFrameworkCore;

namespace ContactTracker.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly AplicationDbContext dbContext;

        public ContactRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        async Task IContactRepository.AddAsync(Contact c)
        {
            await dbContext.Contacts.AddAsync(c);
        }

        async Task<Contact> IContactRepository.GetAsync(Guid id)
        {
            var Contact = await dbContext.Contacts.SingleOrDefaultAsync(x => x.Id == id);
            return Contact ?? throw new KeyNotFoundException($"Contact with id {id} not found");
        }

        async Task<IEnumerable<Contact>> IContactRepository.ListAsync()
        {
            return await dbContext.Contacts.ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }
        async Task IConcactRepository.DeleteAsync(Guid id)
        {
            var Contact = await dbContext.Contacts.SingleOrDefaultAsync(x => x.Id == id);

            if (Contact == null) return;

        }

    }
}