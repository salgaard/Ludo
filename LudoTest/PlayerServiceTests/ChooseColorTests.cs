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
            Player player = new Player();
            PlayerService playerService = new PlayerService();

            //Act
            player.Color.ColorType = playerService.ChooseColor(ColorType.Blue);

            //Assert
            player.Color.ColorType.Should().Be(ColorType.Blue); 

        }
    }
}
