
using PolicyManagementApi.Data;
using PolicyManagementApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagementApi.Services.ServiceInterfaces
{
   public interface IPolicyPremiumService
    {
        Task<IEnumerable<Policy>> GetAllPolicy();
        Task<Policy> GetPolicy(int policyId);
        Task<Policy> AddPolicy(Policy policy);
        Task<Policy> Updatepolicy(Policy policy);
        Task Deletepolicy(int policyId);
        Task<LookUpTable> GetLookUpData();
    }
}
