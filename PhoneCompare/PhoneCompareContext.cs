using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhoneCompare.Models;

namespace PhoneCompare
{
    public class PhoneCompareContext : DbContext
    {
        public PhoneCompareContext(DbContextOptions<PhoneCompareContext> options)
            : base(options)
        { }

        public DbSet<Login> Login { get; set; }
    }
}
