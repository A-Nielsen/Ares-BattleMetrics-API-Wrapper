using System;
using System.Collections.Generic;
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

        public async Task<Server> GetBMServerAsync(UInt32 ServerID)
        {
            try
            {
                var result = await HttpClient.GetAsync($"https://api.battlemetrics.com/servers/{ServerID}?include=session");
                var json = await result.Content.ReadAsStringAsync();
                var server = JsonConvert.DeserializeObject<BattleMetricsResponse>(json).Server;
                return server;
            }
            catch (Exception) { return null; }
        }
    }
}
