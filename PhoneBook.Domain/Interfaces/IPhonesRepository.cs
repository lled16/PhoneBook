using PhoneBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Interfaces
{
    public interface IPhonesRepository
    {
        Task<PhoneEntity> CreateAsync(PhoneEntity contact);
        Task<IEnumerable<PhoneEntity>> GetPhonesAsync();
        Task<IEnumerable<PhoneEntity>> GetByIdAsync(int? id);
        Task<PhoneEntity> RemoveAsync(PhoneEntity contact);
        Task<PhoneEntity> UpdateAsync(PhoneEntity contact);
    }
}
