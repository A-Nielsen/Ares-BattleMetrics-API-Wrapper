using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BattleMetricsWrapper
{
    public class Server
    {
        public enum BattleMetricsType
        {
            server,
            session,
            unknown
        }

        private BattleMetricsType type;
        private ulong id;
        private ServerAttributes attributes;
        private Relationships relationships;
        private Player[] players;


        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BattleMetricsType Type { get => type; set => type = value; }
        [JsonProperty("id")]
        public ulong Id { get => id; set => id = value; }
        [JsonProperty("attributes")]
        public ServerAttributes Attributes { get => attributes; set => attributes = value; }
        public Relationships Relationships { get => relationships; set => relationships = value; }

        [JsonProperty("included")]
        public Player[] Players { get => players; set => players = value; }

        public override string ToString()
        {
            return $"{id}, {attributes.Name}, {attributes.Players}";
        }
    }
}
