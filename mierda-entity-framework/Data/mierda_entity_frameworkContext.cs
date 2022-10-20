using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mierda_entity_framework.Models;

namespace mierda_entity_framework.Data
{
    public class mierda_entity_frameworkContext : DbContext
    {
        public mierda_entity_frameworkContext (DbContextOptions<mierda_entity_frameworkContext> options)
            : base(options)
        {
        }

        public DbSet<mierda_entity_framework.Models.Student> Student { get; set; } = default!;
    }
}
