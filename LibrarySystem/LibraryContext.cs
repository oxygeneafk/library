using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class LibraryContext : DbContext
    {
        public DbSet<Information> Informations { get; set; }
    }
}
