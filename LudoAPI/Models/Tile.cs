namespace LudoAPI.Models;

public class Tile
{
    private Move move;

    public Tile(Move move)
    {
        this.move = move;
    }
    

    public virtual Move nextMove(Piece piece)
    {
        throw new NotImplementedException();
    }
}