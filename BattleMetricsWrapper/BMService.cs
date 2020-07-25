using System;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace BattleMetricsWrapper
{
    public class BattleMetricsService
    {
        private static HttpClient HttpClient { get; set; }

        public BattleMetricsService()
        {
            BattleMetricsService.HttpClient = new HttpClient();
            BattleMetricsService.HttpClient.DefaultRequestHeaders.ConnectionClose = true;
        }

        public async Task<Server> GetBMServer(UInt32 ServerID)
        {
            try
            {
                var response = await HttpClient.GetAsync($"https://api.battlemetrics.com/servers/{ServerID}?include=session");
                return JsonConvert.DeserializeObject<BattleMetricsResponse>(await response.Content.ReadAsStringAsync()).Server;
            }
            catch (Exception) { return null; }
        }
    }
}
