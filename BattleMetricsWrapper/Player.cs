using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleMetricsWrapper
{
    public class Player
    {

        [JsonProperty("attributes")]
        public PlayerAttributes Attributes { get; set; }

    }

}
