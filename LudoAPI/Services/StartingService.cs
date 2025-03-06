using LudoAPI.Models;

namespace LudoAPI.Services
{
    public class StartingService
    {
        private readonly IPlayerService _playerService;
        private readonly IDiceService _diceService;
        public Dictionary<Player, int> startingRolls = new Dictionary<Player, int>();
        public StartingService(IPlayerService playerService, IDiceService diceService)
        {
            _playerService = playerService;
            _diceService = diceService;
        }

        public void RunStartingRolls()
        {
            throw new NotImplementedException();
        }

        public void FindHighestRoll()
        {
            throw new NotImplementedException();
        }

        public void RemoveNotHighest()
        {
            throw new NotImplementedException();
        }

        public void ReRollHighest()
        {
            throw new NotImplementedException(); 
        }
    }
}
