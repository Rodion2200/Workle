using Newtonsoft.Json;
using System.Collections.Generic;

namespace Workle.Models
{
    public class Cards
    {
        [JsonProperty("Grid Results")]
        public List<Card> Card { get; set; }
    }
}