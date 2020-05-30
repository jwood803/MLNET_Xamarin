using MLNet_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MLNet_Xamarin.Services
{
    public class PredictionService
    {
        private HttpClient _client;

        public PredictionService()
        {
            _client = new HttpClient();

            _client.BaseAddress = new Uri("https://wineapi20200513054508.azurewebsites.net/api/");
        }

        public async Task<string> Predict(WineData wineData)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var jsonString = JsonSerializer.Serialize(wineData, options);

            var inputContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync("model", inputContent);

            var predictedQuality = await response.Content.ReadAsStringAsync();

            return predictedQuality;
        }
    }
}
