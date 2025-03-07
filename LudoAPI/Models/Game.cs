namespace LudoAPI.Models;

public class Game
{
    private Guid Id = Guid.NewGuid();
    //todo could be private if not for test?
    public List<Player> players { get; }
    //Is initially decided by who rolls the highest number on the dice
    public Player? currentPlayer {get; set;}
    //todo board/tiles
    
    public Game(List<Player> players)
    {
        this.players = players;
    }
}
    