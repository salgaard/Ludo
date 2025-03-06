using FluentAssertions;
using LudoAPI.Models;
using LudoAPI.Services;

namespace LudoTest.QueueServiceTests
{
    public class QueueServiceTests
    {

        [Fact]
        public void QueueService_AddPlayerToQueue_PlayerAdded()
        {
            //Arrange
            var yellow = ColorType.Yellow;
            Player player = new(yellow);
            QueueService service = new QueueService();

            //Act
            service.AddPlayerToQueue(player);

            //Assert
            service.Players.Should().Contain(player);
        }

        [Fact]
        public void QueueService_RemovePlayerToQueue_PlayerRemoved()
        {
            //Arrange
            var yellow = ColorType.Yellow;
            var player = new Player(yellow);
            QueueService service = new QueueService();

            //Act
            service.RemovePlayerFromQueue(player);

            //Assert
            service.Players.Should().NotContain(player);
        }
    }
}
