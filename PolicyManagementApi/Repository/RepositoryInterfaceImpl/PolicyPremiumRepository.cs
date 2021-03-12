
using PolicyManagementApi.Models;
using Microsoft.EntityFrameworkCore;
using PolicyManagementApi.Data;
using PolicyManagementApi.Repository.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagementApi.Repository.RepositoryInterfaceImpl
{
    public class PolicyPremiumRepository : IPolicyPremiumRepository
    {
        private readonly PolicyPremiumDbContext appDbContext;

         
        public PolicyPremiumRepository(PolicyPremiumDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Policy> AddPolicy(Policy policy)
        {
            var result = await appDbContext.Policies.AddAsync(policy);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task Deletepolicy(int policyId)
        {
            var result = await appDbContext.Policies
                .FirstOrDefaultAsync(e => e.Id ==policyId);
            if (result != null)
            {
                appDbContext.Policies.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Policy>> GetAllPolicy()
        {
            return await appDbContext.Policies.ToListAsync();
        }

        public async Task<LookUpTable> GetLookUpData()
        {
            var result = new LookUpTable();
            var modelMake = new List<ModelMake>
            {
            new ModelMake { Id = 1, CarModel = "Corolla", CardMake  ="Toyota" },
            new ModelMake { Id = 2, CarModel = "Camery", CardMake  = "Toyota" },
            new ModelMake { Id = 3, CarModel= "Accord",CardMake  = "Honda" },
            new ModelMake { Id = 4, CarModel = "Civic", CardMake  = "Honda" }
            };

            var premiumType = new List<PremiumType> {
            new PremiumType { Id = 1, Premium = "₦5000", PremType ="Car" },
            new PremiumType { Id = 2, Premium = "₦5000", PremType = "SUV" },
            new PremiumType { Id = 3, Premium = "₦7500", PremType = "Truck" },
            new PremiumType { Id = 4, Premium = "₦5000", PremType = "Van" }
        };

            result.modelMake = modelMake;
            result.premiumType = premiumType;
            return  result;

        }

        public async Task<Policy> GetPolicy(int policyId)
        {
            return await appDbContext.Policies
                 .FirstOrDefaultAsync(e => e.Id == policyId);
        }

        public async Task<Policy> Updatepolicy(Policy policy)
        {
            var result = await appDbContext.Policies
                .FirstOrDefaultAsync(e => e.Id == policy.Id);

            if (result != null)
            {
                result.FirstName = policy.FirstName;
                result.LastName = policy.LastName;
                result.PhoneNumber = policy.PhoneNumber;
                result.RegistrationNumber = policy.RegistrationNumber;
                result.DateOfBirth = policy.DateOfBirth;
                result.CarModel = policy.CarModel;
                
            
                appDbContext.Entry(result).State = EntityState.Modified;
                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

        
    }
}
