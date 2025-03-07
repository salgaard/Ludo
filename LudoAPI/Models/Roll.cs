namespace LudoAPI.Models
{
    public class Roll
    {
        public Player Player { get; }

        private int value;

        public Roll(Player _player, int _value)
        {
            this.Player = _player;
            this.value = _value;
        }
    }
}
