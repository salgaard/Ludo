namespace LudoAPI.Models;

public class ArrowTile : Tile
{
    private ColorType color;
    private Move arrowMove;
    
    public ArrowTile(Move move, Move arrowMove, ColorType color) : base(move)
    {
        this.arrowMove = arrowMove;
        this.color = color;
    }

    public override Move nextMove(Piece piece)
    {
        throw new NotImplementedException();
    }
}