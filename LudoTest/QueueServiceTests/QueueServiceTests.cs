using FluentAssertions;
using LudoAPI.Models;
using LudoAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoTest.QueueServiceTests
{
    public class QueueServiceTests
    {

        [Fact]
        public void QueueService_AddPlayerToQueue_PlayerAdded()
        {
            //Arrange
            Player player = new();
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
            Player player = new();
            QueueService service = new QueueService();

            //Act
            service.RemovePlayerFromQueue(player);

            //Assert
            service.Players.Should().NotContain(player);
        }
    }
}
