using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Core.IServices
{
    public interface IContactService
    {
        Task<IEnumerable<Contact>> GetListOfContactAsync();
        Task<Contact> GetContactByIdAsync(int id);
        Task<Contact> AddContactAsync(Contact contact);
        Task<Contact> DeleteContactAsync(int id);
        Task<Contact> UpdateContactAsync(int id, Contact contact);
    }
}
