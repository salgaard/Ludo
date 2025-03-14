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
            int playerCount = lobby.Players.Count();

            int rollCount = lobby.StartingRolls.Count();

            if (rollCount >= playerCount)
            {
                //Todo: fejlbesked
                throw new Exception("All players have rolled");
            }

            var player = lobby.Players[rollCount];
            var value = _diceService.RollDice();

            var newRoll = new Roll(player, value);
            lobby.StartingRolls.Add(newRoll);

            return lobby;



        }
    }
}
