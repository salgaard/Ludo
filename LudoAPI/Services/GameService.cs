using LudoAPI.Models;

namespace LudoAPI.Services
{
    public class GameService : IGameService
    {

        public Game StartNewGame(List<Player> players)
        {
            //Create and assign pieces to players
            //Create Board
            //Place player pieces in starting spots
            //Return Game
            throw new NotImplementedException();
        }

        public Player HaveTurn(Game game, Player player)
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
