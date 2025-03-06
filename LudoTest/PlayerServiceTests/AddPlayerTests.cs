using LudoAPI.Models;
using LudoAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoTest.PlayerServiceTests
{
    public class AddPlayerTests
    {

        [Fact]
        public void AddPlayer_ShouldIncreasePlayerCountByOne()
        {
            // Arrange
            PlayerService service = new PlayerService();
            int initialCount = service.Players.Count;

            // Act
            service.AddPlayer();

            // Assert
            Assert.Equal(initialCount + 1, service.Players.Count);

        }
    }
}
