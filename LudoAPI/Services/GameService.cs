﻿using LudoAPI.Models;

namespace LudoAPI.Services
{
    public class GameService : IGameService
    {
        private readonly IQueueService _queueService;
        public Player CurrentPlayer { get; set; }

        public GameService(IQueueService queueService)
        {
            _queueService = queueService;
        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }

        public Player HaveTurn(Player player)
        {
            throw new NotImplementedException();
        }
        
        public void NewTurn()
        {
            
            //tager currentplayer til køen og sætter den næste player til currentplayer

            throw new NotImplementedException();
        }
    }
}
