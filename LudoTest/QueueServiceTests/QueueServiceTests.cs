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
            var yellow = ColorType.Yellow;
            var piece1 = new Piece(yellow);
            var piece2 = new Piece(yellow);
            var piece3 = new Piece(yellow);
            var piece4 = new Piece(yellow);
            Player player = new(yellow, new List<Piece> { piece1, piece2, piece3, piece4 });
            QueueService service = new QueueService();

            //Act
            service.AddPlayerToQueue(player);

            //Assert
            player.Should().NotBeNull();
            service.Players.Should().Contain(player);
            player.Color.Should().Be(yellow);
            piece1.Color.Should().Be(yellow);
            piece2.Color.Should().Be(yellow);
            piece3.Color.Should().Be(yellow);
            piece4.Color.Should().Be(yellow);


        }

        [Fact]
        public void QueueService_RemovePlayerToQueue_PlayerRemoved()
        {
            //Arrange
            var yellow = ColorType.Yellow; //??
            var piece1 = new Piece(yellow);
            var player = new Player(yellow, new List<Piece> { piece1 });
            QueueService service = new QueueService();

            //Act
            service.RemovePlayerFromQueue(player);

            //Assert
            service.Players.Should().NotContain(player);
            player.Color.Should().Be(yellow);
            piece1.Color.Should().Be(yellow);
        }
    }
}
