using LudoAPI.Models;

namespace LudoAPI.Services
{
    public interface IPlayerService
    {
        List<Player> Players { get; set; }

        void AddPlayer();
        ColorType ChooseColor(ColorType color);
    }
}