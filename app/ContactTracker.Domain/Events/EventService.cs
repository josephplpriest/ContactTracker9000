// using ContactTracker.Domain.Events;

// namespace ContactTracker.Domain.Events
// {
//     public interface IEventService
//     {
//         Task<Event> GetEventAsync(Guid id);

//         Task<IEnumerable<Event>> GetEventsAsync(DateTime startDate, DateTime endDate);

//         Task DeleteEventAsync(DeleteEventDto deleteEventDto);

//         Task CreateEventAsync(CreateEventDto createEventDto);

//         Task UpdateEventAsync(UpdateEventDto updateEventDto);
//     }

//     public class EventService : IEventService
//     {
//         private readonly IEventRepository eventRepository;

//         public EventService(IEventRepository eventRepository, IContactRepository contactRepository)
//         {
//             this.eventRepository = eventRepository;
//             this.contactRepository = contactRepository;
//         }

//         public async Task<Event> GetEventAsync(Guid id)
//         {
//             return await eventRepository.GetAsync(id);
//         }

//         public async Task<IEnumerable<Event>> GetEventsAsync(DateTime startDate, DateTime endDate)
//         {
//             return await eventRepository.ListAsync(startDate, endDate);
//         }

//         public async Task CreateAddressAsync(CreateAddressDto dto)
//         {
//             var customer = await customerRepository.GetAsync(dto.CustomerSub);
//             var address = new Address(customer, dto.AddressLine1, dto.AddressLine2, dto.City, dto.State, dto.Country, dto.ZipCode);

//             await addressRepository.AddAsync(address);

//             await addressRepository.SaveChangesAsync();
//         }

//         public async Task UpdateAddressAsync(UpdateAddressDto dto)
//         {
//             var address = await addressRepository.GetAsync(dto.CustomerSub, dto.AddressId);

//             address.AddressLine1 = dto.AddressLine1;
//             address.AddressLine2 = dto.AddressLine2;
//             address.City = dto.City;
//             address.State = dto.State;
//             address.Country = dto.Country;
//             address.ZipCode = dto.ZipCode;

//             await addressRepository.SaveChangesAsync();
//         }

//         public async Task DeleteAddressAsync(DeleteAddressDto dto)
//         {
//             await addressRepository.DeleteAsync(dto.CustomerSub, dto.AddressId);

//             await addressRepository.SaveChangesAsync();
//         }
//     }
// }