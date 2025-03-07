using LudoAPI.Models;

namespace LudoAPI.Services;

public interface IGameService
{
    public Game Start(Lobby lobby);
    public Player HaveTurn(Game game, Player player);
}