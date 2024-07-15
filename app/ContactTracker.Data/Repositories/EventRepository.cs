using ContactTracker.Domain.Events;
using Microsoft.EntityFrameworkCore;

namespace ContactTracker.Data.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext dbContext;

        public EventRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        async Task IEventRepository.AddAsync(Event e)
        {
            await dbContext.Events.AddAsync(e);
        }
        async Task IEventRepository.DeleteAsync(Guid id)
        {
            var Event = await dbContext.Events.SingleOrDefaultAsync(x => x.Id == id);

            if (Event == null) return;

        }

        async Task<Event> IEventRepository.GetAsync(Guid id)
        {
            var Event = await dbContext.Events.SingleOrDefaultAsync(x => x.Id == id);
            return Event ?? throw new KeyNotFoundException($"Event with id {id} not found");
        }

        async Task<IEnumerable<Event>> IEventRepository.ListAsync(DateTime startDate, DateTime endDate)
        {
            return await dbContext.Events.Where(x => x.Date >= startDate && x.Date <= endDate).ToListAsync();
        }


        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}