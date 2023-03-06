using IRemedios.Core.Entities;
using IRemedios.Core.IRepositories;
using IRemedios.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace IRemedios.Infrastructure.Repositories
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly IRemediosDbContext _context;

        public MedicineRepository(IRemediosDbContext context)
        {
            _context = context;
        }

        public async Task<List<Medicine>> GetAllAsync()
        {
            return await _context.Medicines.ToListAsync();
        }

        public async Task<Medicine> GetByIdAsync(int id)
        {
            return await _context.Medicines.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task CreateAsync(Medicine medicine)
        {
            await _context.Medicines.AddAsync(medicine);
            await _context.SaveChangesAsync();
        }
    }
}
