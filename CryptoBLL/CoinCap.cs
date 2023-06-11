
using System.Collections.Generic;


namespace CryptoContracts
{
    public class CoinCapResponse
    {
        public List<CoinCap> Data { get; set; }
    }

    public class CoinCap
    {
        public string Id { get; set; }
        public string Rank { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Supply { get; set; }
        public string MaxSupply { get; set; }
        public string MarketCapUsd { get; set; }
        public string VolumeUsd24Hr { get; set; }
        public decimal PriceUsd { get; set; }
        public string ChangePercent24Hr { get; set; }
        public string Vwap24Hr { get; set; }

        public string Explorer { get; set; }
    }
}