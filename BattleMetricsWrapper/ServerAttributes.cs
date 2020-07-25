using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BattleMetricsWrapper
{

    public class ServerAttributes
    {
        public ServerAttributes()
        {

        }

        enum Status
        {
            online,
            offline,
            dead,
            removed,
            invalid
        }

        private string name;
        private string address;
        private string ip;
        private int port;
        private int players;
        private int maxPlayers;
        private int rank;
        private Status status;
        private AttributeDetails details;
        private DateTime createdAt;
        private DateTime updatedAt;
        private string country;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Ip { get => ip; set => ip = value; }
        public int Port { get => port; set => port = value; }
        public int Players { get => players; set => players = value; }
        public int MaxPlayers { get => maxPlayers; set => maxPlayers = value; }
        public int Rank { get => rank; set => rank = value; }
        private Status Status1 { get => status; set => status = value; }
        public AttributeDetails Details { get => details; set => details = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }
        public string Country { get => country; set => country = value; }
    }
}
