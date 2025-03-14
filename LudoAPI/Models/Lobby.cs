namespace LudoAPI.Models;

public class Lobby
{
    public Guid Id { get; } = Guid.NewGuid();
    
    public List<Player> Players { get; } 

    public List<Roll> StartingRolls { get; set; } = new List<Roll>();
    
    public Lobby(List<Player> players)
    {
        Players = players;
    }
}