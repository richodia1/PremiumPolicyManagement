
using PolicyManagementApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagementApi.Data
{
    public class PolicyPremiumDbContext : DbContext
    {
        public PolicyPremiumDbContext(DbContextOptions<PolicyPremiumDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Policy> Policies { get; set; }
        public DbSet<ModelMake> ModelMakes { get; set; }
        public DbSet<PremiumType> PremiumTypes { get; set; }

    }
}
