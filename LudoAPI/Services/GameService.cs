using LudoAPI.Models;

namespace LudoAPI.Services
{
    public class GameService
    {
        private readonly IQueueService _queueService;

        public GameService(IQueueService queueService)
        {
            _queueService = queueService;
        }

        public Player CurrentPlayer { get; set; }
        public void StartGame()
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
