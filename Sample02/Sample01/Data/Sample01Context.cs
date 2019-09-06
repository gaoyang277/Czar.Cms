using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sample01.Models
{
    public class Sample01Context : DbContext
    {
        public Sample01Context (DbContextOptions<Sample01Context> options)
            : base(options)
        {
        }

        public DbSet<Sample01.Models.Content> Content { get; set; }
    }
}
