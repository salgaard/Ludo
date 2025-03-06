namespace LudoAPI.Models
{
    public class Piece
    {
        public Guid Id { get; } = Guid.NewGuid();
        public ColorType Color;

        public Piece(ColorType color)
        {
            Color = color;
        }
    }

  
}
