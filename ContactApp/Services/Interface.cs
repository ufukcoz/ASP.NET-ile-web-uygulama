using ContactApp.Models;

namespace ContactApp.Services
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAllContacts();
        Contact? GetById(int id);
        Contact Add(Contact contact);
        bool Update(Contact contact);
        bool Delete(int id);

    }
}
