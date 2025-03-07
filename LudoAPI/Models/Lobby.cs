namespace LudoAPI.Models;

public class Lobby
{
    public Guid Id { get; } = Guid.NewGuid();
    
    public List<Player> Players { get; }
    
    public Lobby(List<Player> players)
    {
        Players = players;
    }
}