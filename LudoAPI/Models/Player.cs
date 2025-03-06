namespace LudoAPI.Models
{
    public class Player
    {
        public Color Color { get;}
        
        //pieces are added when starting new game
        public List<Piece>? Pieces { get; set; }

        private int turnsLeft { get; set; } = 0;

        public Player(Color color)
        {
            Color = color;
        }
    }
}
