using LudoAPI.Models;
using LudoAPI.Services;

namespace LudoTest.Services;

public class GameServiceTest
{

    [Fact]
    public void HaveTurnTest()
    {
        //Arrange
        var yellow = ColorType.Yellow;
        var piece1 = new Piece(yellow);
        var player = new Player(yellow, new List<Piece> { piece1 });

        //Act
        //Assert


    }
}