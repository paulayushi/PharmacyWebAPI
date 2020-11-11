using Microsoft.EntityFrameworkCore;
using PharmacyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyWebAPI.Repo
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Medicine> Medicines { get; set; }
    }
}
