using FluentAssertions;
using LudoAPI.Models;
using LudoAPI.Services;

namespace LudoTest.QueueServiceTests
{
    public class QueueServiceTests
    {

        //Bruges til når en players tur er færdig
        [Fact]
        public void QueueService_AddPlayerToQueue_PlayerAdded()
        {
            //Arrange
            var playerId = 4;
            var yellow = (Color) playerId;
            var piece1 = new Piece(yellow);
            var piece2 = new Piece(yellow);
            var piece3 = new Piece(yellow);
            var piece4 = new Piece(yellow);
            Player player = new(playerId)
            {
                Pieces = [piece1, piece2, piece3, piece4]
            };
            
            QueueService service = new QueueService();

            //Act
            service.AddPlayerToQueue(player);

            //Assert
            player.Should().NotBeNull();
            service.Players.Should().Contain(player);
            
            Assert.Equal(Color.Yellow, (Color)player.Id);
            piece1.Color.Should().Be(yellow);
            piece2.Color.Should().Be(yellow);
            piece3.Color.Should().Be(yellow);
            piece4.Color.Should().Be(yellow);
        }


        //Bruges til når det er en ny players tur til at spille
        [Fact]
        public void QueueService_RemovePlayerToQueue_PlayerRemoved()
        {
            //Arrange
            var playerId = 2;
            var green = (Color)2;
            var piece1 = new Piece(green);
            var piece2 = new Piece(green);
            var piece3 = new Piece(green);
            var piece4 = new Piece(green); 
            Player player = new(playerId)
            {
                Pieces = [piece1, piece2, piece3, piece4]
            };

            QueueService service = new QueueService();

            //Act
            service.RemovePlayerFromQueue(player);

            //Assert
            service.Players.Should().NotContain(player);
            
            Assert.Equal(Color.Green, (Color)player.Id);
            piece1.Color.Should().Be(green);

        }
        
    }
}
