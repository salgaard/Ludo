using LudoAPI.Models;
using System.Collections.Concurrent;

namespace LudoAPI.Services
{
    public class StartingService
    {
        private readonly IPlayerService _playerService;
        private readonly IDiceService _diceService;

        public StartingService(IDiceService diceService)
        {
            _diceService = diceService;
        }

        public Lobby HandleRerolls(Lobby lobby)
        {
            throw new NotImplementedException();
        }

        public List<LobbyPlayer> GetReRollers(List<Roll> startingRolls)
        {
            throw new NotImplementedException();
        }

        public bool ShouldReRoll(List<Roll> startingRolls)
        {
            throw new NotImplementedException();
        }

        public Lobby StartingRoll(Lobby lobby)
        {
            throw new NotImplementedException();
        }
    }
}
