namespace LudoAPI.Models
{
    public class Player
    {
        // number from 1-4
        public int Id { get; }

        public List<Piece>? Pieces { get; set; }

        public Player(int id)
        {
            Id = id;
        }
    }
}
