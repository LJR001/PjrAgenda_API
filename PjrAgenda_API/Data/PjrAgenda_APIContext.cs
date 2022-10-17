using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PjrAgenda_API.Models;

namespace PjrAgenda_API.Data
{
    public class PjrAgenda_APIContext : DbContext
    {
        public PjrAgenda_APIContext (DbContextOptions<PjrAgenda_APIContext> options)
            : base(options)
        {
        }

        public DbSet<PjrAgenda_API.Models.Person> Person { get; set; }

        public DbSet<PjrAgenda_API.Models.Address> Address { get; set; }
    }
}
