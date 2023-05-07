using InvoiceSystem.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InvoiceSystem.Service
{
    public class InvoiceService : IInvoiceService
    {
        private readonly HttpClient _httpClient;

        public InvoiceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AddInvoiceAsync(InvoiceInfoModel invoiceInfo, List<InvoiceDetailsModel> invoiceDetails)
        {
            JArray paramList = new JArray();
            paramList.Add(invoiceInfo);
            paramList.Add(invoiceDetails);
            var requestContent = new StringContent(JsonConvert.SerializeObject(paramList), Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await _httpClient.PostAsync("api/InvoiceController",requestContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                var results = responseMessage.Content.ReadAsStringAsync().Result;
            }
        }

        public async Task<IList<InvoiceInfoModel>> GetAllInvoiceInfos()
        {
            List<InvoiceInfoModel> invoices = new List<InvoiceInfoModel>();
            HttpResponseMessage responseMessage = await _httpClient.GetAsync("api/InvoiceController");
            if (responseMessage.IsSuccessStatusCode)
            {
                var results= responseMessage.Content.ReadAsStringAsync().Result;
                invoices = JsonConvert.DeserializeObject<List<InvoiceInfoModel>>(results);
            }
            return invoices;
        }

        public async Task<InvoiceInfoModel> GetInvoiceInfos(string id)
        {
            InvoiceInfoModel invoices = new InvoiceInfoModel();
            HttpResponseMessage responseMessage = await _httpClient.GetAsync("api/<InvoiceController>/"+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var results = responseMessage.Content.ReadAsStringAsync().Result;
                invoices = JsonConvert.DeserializeObject<InvoiceInfoModel>(results);
            }
            return invoices;
        }

        public async Task UpdateInvoiceAsync(InvoiceInfoModel invoiceInfo, List<InvoiceDetailsModel> invoiceDetails)
        {
            JArray paramList = new JArray();
            paramList.Add(invoiceInfo);
            paramList.Add(invoiceDetails);
            var requestContent = new StringContent(JsonConvert.SerializeObject(paramList), Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await _httpClient.PutAsync("api/InvoiceController", requestContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                var results = responseMessage.Content.ReadAsStringAsync().Result;
            }
        }

    }
}
