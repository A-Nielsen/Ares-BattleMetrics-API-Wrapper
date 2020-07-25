namespace BattleMetricsWrapper
{
    public class Relationships
    {
        private game game;
        public string GameType { get => Game.data.type; }
        public string GameId { get => Game.data.id; }
        public game Game { get => game; set => game = value; }
    }
    public class game
    {
        public data data;
    }

    public class data
    {
        public string type;
        public string id;
    }

}
