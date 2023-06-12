using CryptoContracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CryptoBLL
{
    public class CoinCapService : ICoinSerivce
    {
        private readonly Uri _url = new Uri("https://api.coincap.io");
        private readonly HttpClient _httpClient;

        public CoinCapService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = _url;
            _httpClient.Timeout = TimeSpan.FromSeconds(10);
        }

        public async Task<List<Coin>> GetTopCoins()
        {
            var response = await _httpClient.GetAsync("/v2/assets");
            
            var responseContent = await response.Content.ReadAsStringAsync();
            var dataWrapper = JsonConvert.DeserializeObject<DataWrapper>(responseContent);
            List<Coin> result = dataWrapper.Data;

            return result;
        }

        public async Task<List<Coin>> GetCoinByName(string name)
        {
            var response = await _httpClient.GetAsync($"/v2/assets?search={name}");
            var responseContent = await response.Content.ReadAsStringAsync();
            var dataWrapper = JsonConvert.DeserializeObject<DataWrapper>(responseContent);
            List<Coin> result = dataWrapper.Data;

            return result;
        }


        public class DataWrapper
        {
            public List<Coin> Data { get; set; }
        }

    }
}
