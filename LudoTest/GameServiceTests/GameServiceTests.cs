using LudoAPI.Models;
using LudoAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoTest.GameServiceTests
{
    public class GameServiceTests
    {
        [Fact]
        public void GameService_NewTurn_BackToQueue()
        {
            //Arrange
            Player player = new Player();
            GameService service = new GameService();
            
            //Act

            //Assert
        }
    }
}
