using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PetApp.Models
{
    public class PetAppContext : DbContext
    {
        public PetAppContext (DbContextOptions<PetAppContext> options)
            : base(options)
        {
        }

        public DbSet<PetApp.Models.Pet> Pet { get; set; }
    }
}
