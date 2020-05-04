using PhoneCompare.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IPhoneRepository
    {
        Phone GetPhoneById(int id);
        IEnumerable<Phone> GetAllPhones();
        Task<IEnumerable<Phone>> Search(string searchTerm);
        Phone AddPhone(Phone phone);
        Phone UpdatePhone(Phone phone);
        void DeletePhone(int id);
    }
}