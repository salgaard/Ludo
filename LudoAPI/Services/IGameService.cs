using LudoAPI.Models;

namespace LudoAPI.Services;

public interface IGameService
{

    public void StartGame();
    public Player HaveTurn(Player player);
}