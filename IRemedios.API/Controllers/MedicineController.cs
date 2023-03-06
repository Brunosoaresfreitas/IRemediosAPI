using IRemedios.Core.Entities;
using IRemedios.Core.IRepositories;
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
        public async Task<IActionResult> Post([FromBody] Medicine medicine)
        {
            var id = new Medicine(medicine.Name, medicine.Description, medicine.Manufacturer, medicine.DosageInstructions, medicine.Warnings);

            return CreatedAtAction(nameof(GetById), new { id = id.Id }, medicine);
        }
    }
}
