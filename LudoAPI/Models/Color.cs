namespace LudoAPI.Models
{
    public class Color
    {

        public ColorType ColorType { get; set; }


    }
    public enum ColorType
    {
        Blue,
        Green,
        Red,
        Yellow
    }
}
