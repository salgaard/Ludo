using FluentAssertions;
using LudoAPI.Models;
using LudoAPI.Services;
using Moq;

namespace LudoTest.GameServiceTests
{
    public class GameServiceTests
    {

        [Fact]
        public void GameService_NewTurn_BackToQueue()
        {
            //Arrange
            GameService service = new GameService();

            //Act
            service.NewTurn();

            //Assert
            //queueService.Players.Should().Contain(player);
        }

        [Fact]
        public void StartNewGame()
        {
            //Arrange 
            GameService service = new GameService();
            var bluePlayer = new Player(1);
            var redPlayer = new Player(2);
            var yellowPlayer = new Player(3);
            var greenPlayer = new Player(4);
            var players = new List<Player> { bluePlayer, redPlayer, yellowPlayer, greenPlayer };
            
            //Act
            var newGame = service.StartNewGame(players);
            
            //Assert
            
            //A starting player hasn't yet been decided
            newGame.currentPlayer.Should().BeNull();
            
            newGame.players.Count.Should().Be(4);
            newGame.players.Should().BeEquivalentTo(players);
            
        }
    }
}
