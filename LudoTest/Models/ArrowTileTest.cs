using LudoAPI.Models;

namespace LudoTest.Models;

public class ArrowTileTest
{

    [Fact]
    public void NextMoveTest()
    {
        //Arrange
        var defaultMove = new Move(1, 0);
        var arrowMove = new Move(0, 1);
        var redColor = ColorType.Red;
        var blueColor = ColorType.Blue;
        var arrowTile = new ArrowTile(defaultMove, arrowMove, redColor);
        var redPiece = new Piece(redColor);
        var bluePiece = new Piece(blueColor);

        //Act
        var matchingColor = arrowTile.nextMove(redPiece);
        var nonMatchingColor = arrowTile.nextMove(bluePiece);

        //Assert
        Assert.Equal(arrowMove, matchingColor);
        Assert.Equal(defaultMove, nonMatchingColor);
        
    }
}