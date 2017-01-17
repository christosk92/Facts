using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactsAPI.Objects
{
    public class MonthFact
    {

        [JsonProperty("text")]
        public string text { get; set; }

        [JsonProperty("year")]
        public int year { get; set; }

        [JsonProperty("number")]
        public int number { get; set; }

        [JsonProperty("found")]
        public bool found { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }
    }
}