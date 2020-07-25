using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BattleMetricsWrapper
{
    public class BMService
    {

        public async Task<Server> GetBMServer(int serverId)
        {
            try
            {
                var bmClient = new HttpClient();
                var result = await bmClient.GetAsync($"https://api.battlemetrics.com/servers/{serverId}?include=session");
                string json = await result.Content.ReadAsStringAsync();
                var server = JsonConvert.DeserializeObject<BattleMetricsResponse>(json).Server;
                return server;
            }
            catch (Exception ex) { return null; }
        }
    }
}
