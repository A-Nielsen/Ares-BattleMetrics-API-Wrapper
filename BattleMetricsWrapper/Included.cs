using Newtonsoft.Json;
using System;

namespace BattleMetricsWrapper
{
    public class Player
    {

        [JsonProperty("attributes")]
        public PlayerAttributes Attributes { get; set; }

    }


    public class PlayerAttributes
    {
        [JsonProperty("firstTime")]
        public bool FirstTime { get; set; }

        [JsonProperty("start")]
        public DateTimeOffset Start { get; set; }

        [JsonProperty("stop")]
        public object Stop { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("metadata")]
        public MetaData[] Metadata { get; set; }

        public partial class MetaData
        {
            [JsonProperty("key")]
            public Key Key { get; set; }

            [JsonProperty("value")]
            public double Value { get; set; }

            [JsonProperty("private")]
            public bool Private { get; set; }
        }
        public enum Key { Score, Time };
    }
}
