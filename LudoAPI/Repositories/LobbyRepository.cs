using LudoAPI.Models;

namespace LudoAPI.Repositories
{
    public class LobbyRepository
    {
        public List<Lobby> Lobbies { get; } = new List<Lobby>();

        public Lobby AddNewLobby(Lobby lobby)
        {
            Lobby newLobby = new(lobby.Players, GetNextId());
            Lobbies.Add(newLobby);
            return newLobby;
        }

        public int GetNextId()
        {
            if (Lobbies.Count() == 0)
            {
                return 1;
            }
            else
            {
               return Lobbies[Lobbies.Count()-1].Id+1;
            }

        }



        public Lobby Get(int id)
        {
            throw new NotImplementedException();
        }

    }
}
