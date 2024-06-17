using ContactTracker.Domain.Events;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactTracker.Data.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext dbContext;

        public EventRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        async Task IEventRepository.DeleteAsync(Guid id)
        {
            var Event = await dbContext.Event.SingleOrDefaultAsync(x => x.Id == id);

            if (Event == null) return;

        }

        async Task<Event> IEventRepository.GetAsync(Guid id)
        {
            return await dbContext.Event.SingleOrDefaultAsync(x => x.Id == id);
        }

        async Task<IEnumerable<Event>> IEventRepository.ListAsync(DateTime startDate, DateTime endDate)
        {
            return await dbContext.Event.Where(x => x.Date >= startDate && x.Date <= endDate).ToListAsync();
        }

        async Task IEventRepository.AddAsync(Event e)
        {
            await dbContext.Event.AddAsync(e);
        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }
    }
}