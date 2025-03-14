namespace LudoAPI.Models
{
    public class Roll
    {
        public LobbyPlayer Player { get; }

        private int value;

        public Roll(LobbyPlayer _player, int _value)
        {
            this.Player = _player;
            this.value = _value;
        }
    }
}
