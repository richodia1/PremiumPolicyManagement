
using PolicyManagementApi.Data;
using PolicyManagementApi.Models;
using PolicyManagementApi.Repository.RepositoryInterfaces;
using PolicyManagementApi.Services.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagementApi.Services.ServiceInterfaceImpl
{
    public class PolicyPremiumService : IPolicyPremiumService
    {
        private readonly IPolicyPremiumRepository PolicyPremiumRepository;

        public PolicyPremiumService(IPolicyPremiumRepository PolicyPremiumRepository)
        {
            this.PolicyPremiumRepository = PolicyPremiumRepository;
        }
        public async Task<Policy> AddPolicy(Policy policy)
        {
            return await PolicyPremiumRepository.AddPolicy(policy);
        }

        public async Task Deletepolicy(int policyId)
        {
           await PolicyPremiumRepository.Deletepolicy(policyId);
        }

        public async Task<IEnumerable<Policy>> GetAllPolicy()
        {
            return await PolicyPremiumRepository.GetAllPolicy();
        }

        public async Task <LookUpTable> GetLookUpData()
        {
            return await PolicyPremiumRepository.GetLookUpData();
           
        }

        public async Task<Policy> GetPolicy(int policyId)
        {
            return await PolicyPremiumRepository.GetPolicy(policyId);
        }

        public async Task<Policy> Updatepolicy(Policy policy)
        {
            return await PolicyPremiumRepository.Updatepolicy(policy);
        }
    }
}
