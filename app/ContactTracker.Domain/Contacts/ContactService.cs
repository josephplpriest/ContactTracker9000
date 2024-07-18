using ContactTracker.Domain.Contacts;


namespace ContactTracker.Domain.Contacts
{
    public interface IContactService
    {
        Task<Contact> GetContactAsync(Guid id);

        Task<IEnumerable<Contact>> GetContactsAsync();

        Task DeleteContactAsync(DeleteContactDto deleteContactDto);

        Task CreateContactAsync(CreateContactDto createContactDto);

        Task UpdateContactAsync(UpdateContactDto updateContactDto);
    }

    public class ContactService : IContactService
    {
        private readonly IContactRepository contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public async Task<Contact> GetContactAsync(Guid id)
        {
            return await contactRepository.GetAsync(id);
        }

        public async Task<IEnumerable<Contact>> GetContactsAsync()
        {
            return await contactRepository.ListAsync();
        }

        public async Task CreateContactAsync(CreateContactDto dto)
        {
            var c = new Contact
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PreferredName = dto.PreferredName,
                Occupation = dto.Occupation,
                Interests = dto.Interests,
                Relationship = dto.Relationship,
            };

            await contactRepository.AddAsync(c);
            await contactRepository.SaveChangesAsync();
        }

        public async Task UpdateContactAsync(UpdateContactDto dto)
        {
            var c = await contactRepository.GetAsync(dto.ContactId);

            c.FirstName = dto.FirstName;
            c.LastName = dto.LastName;
            c.PreferredName = dto.PreferredName;
            c.Occupation = dto.Occupation;
            c.Interests = dto.Interests;
            c.Relationship = dto.Relationship;

            contactRepository.Update(c);
            await contactRepository.SaveChangesAsync();
        }

        public async Task DeleteContactAsync(DeleteContactDto dto)
        {
            await contactRepository.DeleteAsync(dto.ContactId);
            await contactRepository.SaveChangesAsync();
        }
    }
}

