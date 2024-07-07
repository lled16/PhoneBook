using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Entities;
using PhoneBook.Domain.Interfaces;
using PhoneBook.InfraData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.InfraData.Repositories
{
    public class PhonesRepository : IPhonesRepository
    {
        private ApplicationDbContext _context;

        public PhonesRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PhoneEntity> CreateAsync(PhoneEntity phone)
        {
            _context.Add(phone);
            await _context.SaveChangesAsync();
            return phone;
        }
        public async Task<IEnumerable<PhoneEntity>> GetPhonesAsync()
        {
            return await _context.Telefones.ToListAsync();
        }

        public async Task<IEnumerable<PhoneEntity>> GetByIdAsync(int? id)
        {
            return await _context.Telefones.Where(t => t.ContactId == id).ToListAsync();
               
        }

        public async Task<PhoneEntity> RemoveAsync(PhoneEntity phone)
        {
            _context.Remove(phone);
            await _context.SaveChangesAsync();
            return phone;
        }

        public async Task<PhoneEntity> UpdateAsync(PhoneEntity phone)
        {
            _context.Update(phone);
            await _context.SaveChangesAsync();
            return phone;
        }
    }
}
