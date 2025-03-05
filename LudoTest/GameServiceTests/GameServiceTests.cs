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
            Player player = new Player();
            Player player2 = new Player();

            QueueService queueService = new QueueService();
            queueService.AddPlayerToQueue(player);
            queueService.AddPlayerToQueue(player2);

            GameService service = new GameService(queueService);

            //Act
            service.NewTurn();

            //Assert
            service.CurrentPlayer.Should().Be(player);
        }
    }
}
