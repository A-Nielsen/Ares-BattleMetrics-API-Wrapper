using System;
using System.Threading.Tasks;

using BattleMetricsWrapper;

namespace ApiTest
{
    internal class Program
    {
        private static async Task Main()
        {
            var service = new BattleMetricsService();

            var server = await service.GetBMServerAsync(7018681);
            Console.WriteLine(server.ToString());
        }
    }
}
