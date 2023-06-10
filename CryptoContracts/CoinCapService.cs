
using CryptoContracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CryptoBLL
{
    public class CoinCapService : ICoinsService
    {
        public async Task<List<CoinCap>> GetTopCoins()
        {
            using var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.coincap.io");
            httpClient.Timeout = TimeSpan.FromSeconds(10);
            var response = await httpClient.GetAsync("/v2/assets");
            var responseContent = await response.Content.ReadAsStringAsync();

            var dataWrapper = JsonConvert.DeserializeObject<DataWrapper>(responseContent);
            List<CoinCap> result = dataWrapper.Data;

            return result;
        }
        public async Task<List<CoinCap>> GetCoinByName(string name)
        {
            using var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.coincap.io");
            httpClient.Timeout = TimeSpan.FromSeconds(10);
            var response = await httpClient.GetAsync("/v2/assets?search=" + name);
            var responseContent = await response.Content.ReadAsStringAsync();

            var dataWrapper = JsonConvert.DeserializeObject<DataWrapper>(responseContent);
            List<CoinCap> result = dataWrapper.Data;

            return result;
        }
        public async Task<List<CoinCap>> GetCoinInfo(string name)
        {
            using var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.coincap.io");
            httpClient.Timeout = TimeSpan.FromSeconds(10);
            var response = await httpClient.GetAsync("/v2/assets?search=" + name);
            var responseContent = await response.Content.ReadAsStringAsync();

            var dataWrapper = JsonConvert.DeserializeObject<DataWrapper>(responseContent);
            List<CoinCap> result = dataWrapper.Data;

            return result;
        }
       

        public class DataWrapper
        {
            public List<CoinCap> Data { get; set; }
        }

        public class DataWrapperGecko
        {
            public List<CoinGecko> Coins { get;set; }
        }

    }
}
