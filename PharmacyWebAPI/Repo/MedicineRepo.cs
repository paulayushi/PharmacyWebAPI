using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PharmacyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyWebAPI.Repo
{
    public class MedicineRepo : IMedicineRepo
    {
        private readonly ApplicationDBContext _dBContext;
        private readonly IMapper _mapper;

        public MedicineRepo(ApplicationDBContext dBContext, IMapper mapper)
        {
            _dBContext = dBContext;
            _mapper = mapper;
        }
        public async Task CreateMedicine(Medicine medicine)
        {
            await _dBContext.AddAsync<Medicine>(medicine);
            await _dBContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Medicine>> GetAllMedicines()
        {
            return await _dBContext.Medicines.ToListAsync();
        }
    }
}
