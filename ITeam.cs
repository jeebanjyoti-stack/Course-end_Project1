﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_end_project_1
{
    public interface ITeam
    {
        void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        Player GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();
    }
}
