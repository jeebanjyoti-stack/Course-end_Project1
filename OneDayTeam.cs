using System;
using System.Collections.Generic;
using System.Linq;

namespace Course_end_project_1
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            if (oneDayTeam.Count >= 11)
            {
                Console.WriteLine("Cannot add more than 11 players to the team.");
                return;
            }

            oneDayTeam.Add(player);
        }

        public void Remove(int playerId)
        {
            Player player = oneDayTeam.FirstOrDefault(p => p.PlayerId == playerId);
            if (player != null)
            {
                oneDayTeam.Remove(player);
                Console.WriteLine("Player removed successfully.");
            }
            else
            {
                Console.WriteLine("Player not found in the team.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.FirstOrDefault(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.FirstOrDefault(p => p.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
