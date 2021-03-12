using Microsoft.AspNetCore.Components;
using PolicyManagement.UI.Data;
using PolicyManagement.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagement.UI.Pages.Premium
{
    public partial class PremiumDetails : ComponentBase
    {
        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Parameter]
      public  int Id { get; set; }
        [Inject] IPremiumServiceProvider PremiumServiceProvider { get; set; }
        public PolicyRequestModel policyRequestModelDetails { get; set; } = new PolicyRequestModel();

        protected override async Task OnInitializedAsync()
        {

            policyRequestModelDetails = await PremiumServiceProvider.GetPolicy(Id);
            base.OnInitialized();

        }
        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
