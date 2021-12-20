using Newtonsoft.Json;

namespace Workle.Models
{
    public class Card
    {
        [JsonProperty("BIN")]
        public int Bin { get; set; }

        [JsonProperty("BRAND")]
        public string Brand { get; set; }

        [JsonProperty("BIN_TYPE")]
        public string BinType { get; set; }

        [JsonProperty("BIN_LEVEL")]
        public string BinLevel { get; set; }

        [JsonProperty("COUNTRY2_ISO")]
        public string Contry2Iso { get; set; }
    }
}