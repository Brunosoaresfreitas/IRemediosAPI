using IRemedios.Core.Entities;

namespace IRemedios.Core.IRepositories
{
    public interface IMedicineRepository
    {
        Task<List<Medicine>> GetAllAsync();
        Task<Medicine> GetByIdAsync(int id);
        Task CreateAsync(Medicine medicine);
    }
}
