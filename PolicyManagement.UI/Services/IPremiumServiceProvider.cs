using PolicyManagement.UI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagement.UI.Services
{
 public   interface IPremiumServiceProvider
    {
        Task<IEnumerable<PolicyRequestModel>> GetAllPolicy();
        Task<PolicyRequestModel> GetPolicy(int policyId);
        Task<PolicyRequestModel> AddPolicy(PolicyRequestModel policy);
        Task  Updatepolicy(PolicyRequestModel policy);
        Task DeletepolicyAsync(int policyId);
       Task<LookUpTable> GetLookUpData();
    }
}
