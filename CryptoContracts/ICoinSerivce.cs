
using CryptoContracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptoBLL
{
    public interface ICoinSerivce
    {
        public Task<List<Coin>> GetTopCoins();
        public Task<List<Coin>> GetCoinByName(string name);
    }
}
