using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICodeFirstApproach.Models
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Projects> Projects { get; set; }
    }
}
