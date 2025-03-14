namespace LudoAPI.Models
{
    public class Roll
    {
        private Player player;

        private int value;

        public Roll(Player _player, int _value)
        {
            this.player = _player;
            this.value = _value;
        }
    }
}
