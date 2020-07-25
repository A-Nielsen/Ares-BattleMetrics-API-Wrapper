using BattleMetricsWrapper;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var service = new BMService();

            var server = await service.GetBMServer(7018681);
            Console.WriteLine(server.ToString());
        }
    }
}
