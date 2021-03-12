using Microsoft.AspNetCore.Components;
using PolicyManagement.UI.Data;
using PolicyManagement.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyManagement.UI.Pages.Premium
{
    public partial class PremiumCreate : ComponentBase
    {
        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        [Inject]
        NavigationManager NavigationManager { get; set; }
        [Inject] IPremiumServiceProvider PremiumServiceProvider { get; set; }
        public PolicyRequestModel policyRequestModel { get; set; } = new PolicyRequestModel();
        private LookUpTable LookUpData { get; set; } = new LookUpTable();

        private List<ModelMake> modelMakes = new List<ModelMake>
            {
            new ModelMake { Id = 1, CarModel = "Corolla", CardMake  ="Kia" },
            new ModelMake { Id = 2, CarModel = "Camery", CardMake  = "Toyota" },
            new ModelMake { Id = 3, CarModel= "Accord",CardMake  = "Honda" },
            new ModelMake { Id = 4, CarModel = "Civic", CardMake  = "Jeep" }
            };

        private List<PremiumType> premiumTypes = new List<PremiumType> {
            new PremiumType { Id = 1, Premium = "₦5000", PremType ="Car" },
            new PremiumType { Id = 2, Premium = "₦10000", PremType = "SUV" },
            new PremiumType { Id = 3, Premium = "₦7500", PremType = "Truck" },
            new PremiumType { Id = 4, Premium = "₦14000", PremType = "Van" }
        };

        protected override async Task OnInitializedAsync()
        {

            LookUpData = await PremiumServiceProvider.GetLookUpData();
            base.OnInitialized();

        }
        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/");
        }
        protected async Task HandleValidSubmit()
        {
            if (policyRequestModel.Id != 0) // is a new creation 
            {
                var policyPostResponse = await PremiumServiceProvider.AddPolicy(policyRequestModel);

                NavigationManager.NavigateTo("/");
            }
            else
            {
                 await PremiumServiceProvider.Updatepolicy(policyRequestModel);

                NavigationManager.NavigateTo("/");
            }

        }

    }
}
