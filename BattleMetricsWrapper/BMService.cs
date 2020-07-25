using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace BattleMetricsWrapper
{
    public class BattleMetricsService
    {
        private HttpClient bmClient = new HttpClient();

        public BattleMetricsService()
        {
            BattleMetricsService.HttpClient = new HttpClient();
            BattleMetricsService.HttpClient.DefaultRequestHeaders.ConnectionClose = true;
        }

        public async Task<Server> GetBMServerAsync(UInt32 ServerID)
        {
            try
            {
                var result = await bmClient.GetAsync($"https://api.battlemetrics.com/servers/{serverId}?include=session");
                var json = await result.Content.ReadAsStringAsync();
                var server = JsonConvert.DeserializeObject<BattleMetricsResponse>(json).Server;
                return server;
            }
            catch (Exception) { return null; }
        }
    }
}
