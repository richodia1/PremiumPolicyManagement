using Microsoft.Extensions.Logging;
using PolicyManagement.UI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PolicyManagement.UI.Services
{
    public class PremiumServiceProvider : IPremiumServiceProvider
    {
        private readonly HttpClient httpClient;
        private ILogger<PremiumServiceProvider> _logger;


        public PremiumServiceProvider(HttpClient httpClient, ILogger<PremiumServiceProvider> _logger)
        {
            this.httpClient = httpClient;
            this._logger = _logger;
        }
        public async Task<PolicyRequestModel> AddPolicy(PolicyRequestModel policy)
        {
            var expenseJson =
                new StringContent(JsonSerializer.Serialize(policy), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("api/PolicyPremium", expenseJson);

            if (response.IsSuccessStatusCode)
            {
                await JsonSerializer.DeserializeAsync<PolicyRequestModel>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeletepolicyAsync(int policyId)
        {
            await httpClient.DeleteAsync($"api/PolicyPremium/{policyId}");
        }

        public async Task<IEnumerable<PolicyRequestModel>> GetAllPolicy()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<PolicyRequestModel>>
               (await httpClient.GetStreamAsync($"api/PolicyPremium"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        }

        public async Task<LookUpTable> GetLookUpData()
        {
             LookUpTable  result= null;
            string json = string.Empty;
            try
            {
                using (WebClient wc = new WebClient())
                {
                     json = wc.DownloadString($"https://localhost:44310/api/PolicyPremium/request-lookup");
                }
             result = JsonSerializer.Deserialize<LookUpTable>(json);
              
                return result;
            }
           
            catch (Exception ex)
            {
                string msg = ex.Message;
                string msg2 = ex.StackTrace;

            }
            return result;
        }

        public async Task<PolicyRequestModel> GetPolicy(int policyId)
        {
            return await JsonSerializer.DeserializeAsync<PolicyRequestModel>
                (await httpClient.GetStreamAsync($"api/PolicyPremium/{policyId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        }

        public async Task Updatepolicy(PolicyRequestModel policy)
        {
            var expenseJson =
                 new StringContent(JsonSerializer.Serialize(policy), Encoding.UTF8, "application/json");

            await httpClient.PutAsync("api/PolicyPremium", expenseJson);
        }
    }
}
