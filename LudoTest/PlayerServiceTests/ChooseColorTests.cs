using FluentAssertions;
using LudoAPI.Models;
using LudoAPI.Services;

namespace LudoTest.PlayerServiceTests
{
    public class ChooseColorTests
    {

        [Fact]
        public void PlayerService_ChooseColor_Blue()
        {
            //Arrange
            PlayerService playerService = new PlayerService();

            //Act
            var chosenColor = playerService.ChooseColor(ColorType.Blue);
            var player = new Player(chosenColor);
            
            //Assert
            player.Color.Should().Be(ColorType.Blue); 

        }
    }
}
