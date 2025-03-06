namespace LudoAPI.Models
{
    public class Player
    {
        public ColorType Color { get;}

        //pieces are added when starting new game
        public List<Piece>? Pieces { get; set; }

        private int turnsLeft { get; set; } = 0;

        public Player(ColorType color)
        {
            Color = color;
        }
    }

   
}
