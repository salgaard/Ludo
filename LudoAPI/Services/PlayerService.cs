﻿using LudoAPI.Models;

namespace LudoAPI.Services
{
    public class PlayerService : IPlayerService
    {
        private List<Player> players = new();
        public IReadOnlyList<Player> Players => players;

        public Color ChooseColor(Color color)
        {
            throw new NotImplementedException();
        }

        public void AddPlayer()
        {
            throw new NotImplementedException();
        }
    }
}
