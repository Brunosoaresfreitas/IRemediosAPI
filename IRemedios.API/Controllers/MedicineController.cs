using IRemedios.Core.Entities;
using IRemedios.Core.IRepositories;
using IRemedios.Core.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IRemedios.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineRepository _medicineRepository;

        public MedicineController(IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var medicines = await _medicineRepository.GetAllAsync();
            return Ok(medicines);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var medicine = await _medicineRepository.GetByIdAsync(id);
            return Ok(medicine);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MedicineInputModel medicineInputModel)
        {
            var medicine = new Medicine(medicineInputModel.Name, medicineInputModel.Description, medicineInputModel.Manufacturer,
                                        medicineInputModel.DosageInstructions, medicineInputModel.Warnings);
            await _medicineRepository.CreateAsync(medicine);

            return CreatedAtAction(nameof(GetById), new { id = medicine.Id }, medicine);
        }
    }
}
