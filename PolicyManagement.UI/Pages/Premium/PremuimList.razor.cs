using Microsoft.AspNetCore.Components;
using PolicyManagement.UI.Data;
using PolicyManagement.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagement.UI.Pages.Premium
{
    public partial class PremuimList : ComponentBase
    {
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject] IPremiumServiceProvider PremiumServiceProvider { get; set; }
        public PolicyRequestModel policyRequestModel { get; set; } = new PolicyRequestModel();

        public List<PolicyRequestModel> policyList { get; set; } = new List<PolicyRequestModel>();

        protected override async Task OnInitializedAsync()
        {
            policyList = (await PremiumServiceProvider.GetAllPolicy()).ToList();
        }
    }
}
