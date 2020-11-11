using PharmacyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyWebAPI.Repo
{
    public interface IMedicineRepo
    {
        Task<IEnumerable<Medicine>> GetAllMedicines();
        Task CreateMedicine(Medicine medicine);
        //Task UpdateMedicine(Medicine medicine);
    }
}
