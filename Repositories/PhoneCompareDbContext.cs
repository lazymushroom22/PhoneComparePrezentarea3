using Microsoft.EntityFrameworkCore;
using PhoneCompare.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneCompare.Services
{
    public class PhoneCompareDbContext : DbContext
    {
        public PhoneCompareDbContext(DbContextOptions<PhoneCompareDbContext> options)
            : base(options)
        {
        }

        public DbSet<Phone> Phones { get; set; }
    }
}
