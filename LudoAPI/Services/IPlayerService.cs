using LudoAPI.Models;

namespace LudoAPI.Services
{
    public interface IPlayerService
    {
        public IReadOnlyList<Player> Players { get; }
        void AddPlayer();
        ColorType ChooseColor(ColorType color);
        void WaitTurn();
    }
}