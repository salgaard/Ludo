namespace LudoAPI.Models
{
    public class StartingRoll
    {
        public List<Roll>? Rolls { get; set; } = new List<Roll>();

        private Lobby lobby;

        public void addRoll(Roll roll)
        {
            rolls.Add(roll);
        }

        public StartingRoll(Lobby lobby)
        {
            this.lobby = lobby;
        }
    }
}
