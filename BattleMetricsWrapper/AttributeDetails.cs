namespace BattleMetricsWrapper
{
    public class AttributeDetails
    {
        public AttributeDetails()
        {

        }

        private string map;
        private string gameMode;
        private string version;
        private int secure;
        private bool licensedServer;
        private int numPubConn;
        private int numPrivConn;
        private int numOpenPrivConn;
        string serverSteamId;

        public string Map { get => map; set => map = value; }
        public string GameMode { get => gameMode; set => gameMode = value; }
        public string Version { get => version; set => version = value; }
        public int Secure { get => secure; set => secure = value; }
        public bool LicensedServer { get => licensedServer; set => licensedServer = value; }
        public int NumPubConn { get => numPubConn; set => numPubConn = value; }
        public int NumPrivConn { get => numPrivConn; set => numPrivConn = value; }
        public int NumOpenPrivConn { get => numOpenPrivConn; set => numOpenPrivConn = value; }
        public string ServerSteamId { get => serverSteamId; set => serverSteamId = value; }
    }
}
