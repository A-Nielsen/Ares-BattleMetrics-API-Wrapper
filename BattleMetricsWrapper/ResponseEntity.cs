using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleMetricsWrapper
{
    public class BattleMetricsResponse
    {
        [JsonProperty("data")]
        public Server Server;

        [JsonProperty("included")]
        public Player[] Players { get => Server.Players; set => Server.Players = value; }
    }
}
