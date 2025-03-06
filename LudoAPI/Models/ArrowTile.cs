namespace LudoAPI.Models;

public class ArrowTile : Tile
{
    private Color color;
    private Move arrowMove;
    
    public ArrowTile(Move move, Move arrowMove, Color color) : base(move)
    {
        this.arrowMove = arrowMove;
        this.color = color;
    }

    public override Move nextMove(Piece piece)
    {
        throw new NotImplementedException();
    }
}