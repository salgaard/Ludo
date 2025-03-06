using FluentAssertions;
using LudoAPI.Models;
using LudoAPI.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var piece1 = new Piece(Color.Yellow);
            Player player = new Player(Color.Yellow, new List<Piece> { piece1 });
            QueueService queueService = new QueueService();
            GameService service = new GameService(queueService);
            service.CurrentPlayer = player;

            //Act
            service.NewTurn();

            //Assert
            queueService.Players.Should().Contain(player);
        }
    }
}
