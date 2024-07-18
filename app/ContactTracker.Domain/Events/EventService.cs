using ContactTracker.Domain.Events;
using ContactTracker.Domain.Contacts;


namespace ContactTracker.Domain.Events
{
    public interface IEventService
    {
        Task<Event> GetEventAsync(Guid id);

        Task<IEnumerable<Event>> GetEventsAsync(DateTime startDate, DateTime endDate);

        Task DeleteEventAsync(DeleteEventDto deleteEventDto);

        Task CreateEventAsync(CreateEventDto createEventDto);

        Task UpdateEventAsync(UpdateEventDto updateEventDto);
    }

    public class EventService : IEventService
    {
        private readonly IEventRepository eventRepository;
        private readonly IContactRepository contactRepository;

        public EventService(IEventRepository eventRepository, IContactRepository contactRepository)
        {
            this.eventRepository = eventRepository;
            this.contactRepository = contactRepository;
        }

        public async Task<Event> GetEventAsync(Guid id)
        {
            return await eventRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Event>> GetEventsAsync(DateTime startDate, DateTime endDate)
        {
            return await eventRepository.ListAsync(startDate, endDate);
        }

        public async Task CreateEventAsync(CreateEventDto dto)
        {
            var e = new Event
            {
                Date = dto.Date,
                Location = dto.Location,
                Description = dto.Description,
                Type = dto.Type,
                Duration = dto.Duration,
                PreNotes = dto.PreNotes,
                PostNotes = dto.PostNotes,
                InPerson = dto.InPerson,
                contactId = dto.ContactId,
                Contact = dto.Contact
            };

            await eventRepository.AddAsync(e);
            await eventRepository.SaveChangesAsync();
        }

        public async Task UpdateEventAsync(UpdateEventDto dto)
        {
            var e = await eventRepository.GetAsync(dto.EventId);

            e.Date = dto.Date;
            e.Location = dto.Location;
            e.Description = dto.Description;
            e.Type = dto.Type;
            e.Duration = dto.Duration;
            e.PreNotes = dto.PreNotes;
            e.PostNotes = dto.PostNotes;
            e.ThankYouSent = dto.ThankYouSent;
            e.HasOccurred = dto.HasOccurred;
            e.InPerson = dto.InPerson;
            e.contactId = dto.ContactId;
            e.Contact = dto.Contact;

            eventRepository.Update(e);
            await eventRepository.SaveChangesAsync();
        }

        public async Task DeleteEventAsync(DeleteEventDto dto)
        {
            await eventRepository.DeleteAsync(dto.EventId);
            await eventRepository.SaveChangesAsync();
        }
    }
}

