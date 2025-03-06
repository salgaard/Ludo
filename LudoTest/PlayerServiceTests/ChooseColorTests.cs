using FluentAssertions;
using LudoAPI.Models;
using LudoAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var piece = new Piece(chosenColor);
            var player = new Player(chosenColor, [piece]);
            

            //Assert
            player.Color.Should().Be(ColorType.Blue); 

        }
    }
}
