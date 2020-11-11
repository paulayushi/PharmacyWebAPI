using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyWebAPI.Models;
using PharmacyWebAPI.Repo;

namespace PharmacyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineRepo _repo;

        public MedicineController(IMedicineRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> GetMedicines()
        {
            try
            {
                var medicines = await _repo.GetAllMedicines();
                return Ok(medicines);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("createmedicine")]
        public async Task<IActionResult> CreateContact([FromBody] Medicine medicine)
        {
            try
            {
                await _repo.CreateMedicine(medicine);
                return Ok(StatusCodes.Status201Created);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}