using LudoAPI.Models;

namespace LudoAPI.Services;

public interface IGameService
{
    /// <summary>
    /// Starts a new game of Ludo with the specified players. The method assigns pieces to players,
    /// creates the game board, and pieces in the starting positions.
    /// </summary>
    /// <param name="players">A list of players who will participate in the game.</param>
    /// <returns>A new Game object initialized with the specified players.</returns>
    public Game StartNewGame(List<Player> players);
    public Player HaveTurn(Game game, Player player);
}