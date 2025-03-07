using LudoAPI.Models;
using System.Collections.Concurrent;

namespace LudoAPI.Services
{
    public class StartingService
    {
        private readonly IPlayerService _playerService;
        private readonly IDiceService _diceService;
        private readonly ConcurrentDictionary<Player, int> _startingRolls = new();
        public IReadOnlyDictionary<Player, int> StartingRolls => _startingRolls;

        public StartingService(IDiceService diceService)
        {
            _diceService = diceService;
        }

        public ConcurrentDictionary<Player, int> RollAndReturnAllPlayerRolls()
        {
            throw new NotImplementedException();
        }

        public ConcurrentDictionary<Player, int> FindAndReturnHighestRolls()
        {
            throw new NotImplementedException();
        }

        public bool ShouldReRoll()
        {
            throw new NotImplementedException();
        }

        public void AddAndReplaceStartingRolls(ConcurrentDictionary<Player, int> rolls)
        {
            throw new NotImplementedException();
        }

        public List<StartingRoll> StartingRoll(List<StartingRoll> startingRolls)
        {
            throw new NotImplementedException();
        }
    }
}
