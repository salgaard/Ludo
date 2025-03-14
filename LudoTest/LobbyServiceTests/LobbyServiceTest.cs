using LudoAPI.Models;
using LudoAPI.Services;

namespace LudoTest.Services;

public class LobbyServiceTest
{

    [Fact]
    public void CreateLobby()
    {
        //Arrange
        var lobbyService = new LobbyService();
        
        var players = new List<LobbyPlayer>()
        {
            new LobbyPlayer(1), new LobbyPlayer(2), new LobbyPlayer(3), new LobbyPlayer(4)
        };
        
        var expected = new Lobby(players);
        
        //Act
        var actual = lobbyService.CreateLobby();
        
        //Assert
        Assert.Equivalent(expected, actual);
    }
}