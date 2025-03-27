using System;
using System.Collections.Generic;
using System.Numerics;

namespace PMSDataLogic
{
    public class PlayerService
    {
        private readonly List<Player> players = new();

        public bool AddPlayer(string name, int age, string position)
        {
            players.Add(new Player(name, age, position));
            return true;
        }

        public bool EditPlayer(int index, string name, int age, string position)
        {
            if (index < 0 || index >= players.Count)
                return false;

            players[index].Name = name;
            players[index].Age = age;
            players[index].Position = position;
            return true;
        }

        public bool DeletePlayer(int index)
        {
            if (index < 0 || index >= players.Count)
                return false;

            players.RemoveAt(index);
            return true;
        }

        public List<Player> GetAllPlayers()
        {
            return new List<Player>(players);
        }

        public int GetPlayerCount() => players.Count;

        public Player GetPlayerByIndex(int index)
        {
            return (index >= 0 && index < players.Count) ? players[index] : null;
        }
    }
}
