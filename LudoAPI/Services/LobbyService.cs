using LudoAPI.Models;

namespace LudoAPI.Services;

public class LobbyService : ILobbyService
{
    public Lobby CreateLobby()
    {
        var lobbyPlayers = new List<LobbyPlayer>()
        {
            new LobbyPlayer(1),
            new LobbyPlayer(2),
            new LobbyPlayer(3),
            new LobbyPlayer(4),
        };
        var lobby = new Lobby(lobbyPlayers);
        
        return lobby;
    }
}