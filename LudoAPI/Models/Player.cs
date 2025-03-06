namespace LudoAPI.Models
{
    public class Player
    {
        public ColorType Color { get;}

        private List<Piece> pieces { get; set; }

        private int turnsLeft { get; set; } = 0;

        public Player(ColorType color, List<Piece> pieces)
        {
            this.Color = color;
            this.pieces = pieces;
        }
    }

   
}
