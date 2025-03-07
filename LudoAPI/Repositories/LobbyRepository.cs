using LudoAPI.Models;

namespace LudoAPI.Repositories
{
    public class LobbyRepository
    {
        public List<Lobby> Lobbies { get; } = new List<Lobby>();

        public void Add(Lobby game)
        {
            throw new NotImplementedException();
        }

        public Lobby Get(int id)
        {
            throw new NotImplementedException();
        }

    }
}
