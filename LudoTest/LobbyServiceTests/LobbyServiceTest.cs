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
        
        var players = new List<Player>()
        {
            new Player(1), new Player(2), new Player(3), new Player(4)
        };
        
        var expected = new Lobby(players);
        
        //Act
        var actual = lobbyService.CreateLobby();
        
        //Assert
        Assert.Equivalent(expected, actual);
    }
}