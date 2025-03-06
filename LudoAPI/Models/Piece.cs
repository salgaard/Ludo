namespace LudoAPI.Models
{
    public class Piece
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Color Color;
        
        public Piece(Color color)
        {
            Color = color;
        }
    }
}
