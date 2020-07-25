using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BattleMetricsWrapper
{
    public class BMService
    {
        private HttpClient bmClient = new HttpClient();

        public async Task<Server> GetBMServerAsync(int serverId)
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
