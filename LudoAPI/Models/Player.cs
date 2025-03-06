namespace LudoAPI.Models
{
    public class Player
    {
        public Color Color { get;}

        private List<Piece> Pieces { get; set; }

        private int turnsLeft { get; set; } = 0;

        public Player()
        {

        }

        public Player(Color color, List<Piece> pieces)
        {
            this.Color = color;
            this.Pieces = pieces;
        }
    }

   
}
