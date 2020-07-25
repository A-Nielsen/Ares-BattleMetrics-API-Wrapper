using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BattleMetricsWrapper
{
    public class BMService
    {
<<<<<<< HEAD
        private HttpClient bmClient = new HttpClient();

        public async Task<Server> GetBMServerAsync(int serverId)
        {
            try
            {
                var result = await bmClient.GetAsync($"https://api.battlemetrics.com/servers/{serverId}?include=session");
                var json = await result.Content.ReadAsStringAsync();
                var server = JsonConvert.DeserializeObject<BattleMetricsResponse>(json).Server;
                return server;
=======
        private static HttpClient HttpClient { get; set; }

        public BMService()
        {
            BMService.HttpClient = new HttpClient();
            BMService.HttpClient.DefaultRequestHeaders.ConnectionClose = true;
        }

        public async Task<Server> GetBMServer(UInt32 ServerID)
        {
            try
            {
                var response = await HttpClient.GetAsync($"https://api.battlemetrics.com/servers/{ServerID}?include=session");
                return JsonConvert.DeserializeObject<BattleMetricsResponse>(await response.Content.ReadAsStringAsync()).Server;
>>>>>>> pr/1
            }
            catch (Exception) { return null; }
        }
    }
}
