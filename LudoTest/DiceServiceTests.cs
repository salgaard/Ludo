using LudoAPI.Services;

namespace LudoTest
{
    public class DiceServiceTests
    {

        public DiceServiceTests()
        {
        }


        [Fact]
        public void RollDiceTest()
        {
            //Arrange
            DiceService service = new DiceService();

            //Act
            var result = service.RollDice();

            //Assert
            Assert.Equal(1, result);
        }
    }
}
