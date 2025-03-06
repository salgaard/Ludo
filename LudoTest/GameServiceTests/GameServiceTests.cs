using FluentAssertions;
using LudoAPI.Models;
using LudoAPI.Services;
using Moq;

namespace LudoTest.GameServiceTests
{
    public class GameServiceTests
    {
        private readonly Mock<IQueueService> _queueServiceMock;
        
        public GameServiceTests()
        {
            _queueServiceMock = new Mock<IQueueService>();
        }

        [Fact]
        public void GameService_NewTurn_BackToQueue()
        {
            //Arrange
            Player player = new Player(ColorType.Blue);
            QueueService queueService = new QueueService();
            GameService service = new GameService(queueService);

            //Act
            service.NewTurn();

            //Assert
            queueService.Players.Should().Contain(player);
        }

        [Fact]
        public void StartNewGame()
        {
            //Arrange 
            GameService service = new GameService(_queueServiceMock.Object);
            var bluePlayer = new Player(ColorType.Blue);
            var redPlayer = new Player(ColorType.Red);
            var yellowPlayer = new Player(ColorType.Yellow);
            var greenPlayer = new Player(ColorType.Green);
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
