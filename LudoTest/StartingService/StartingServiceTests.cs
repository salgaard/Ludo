using FluentAssertions;
using LudoAPI.Models;
using LudoAPI.Services;
using Moq;
using System.Collections.Concurrent;

namespace LudoTest.StartingServiceTests
{
    public class StartingServiceTests
    {
        private readonly Mock<IPlayerService> _playerServiceMock;
        private readonly Mock<IDiceService> _diceServiceMock;
        private readonly StartingService startingService;
        public StartingServiceTests()
        {
            _playerServiceMock = new Mock<IPlayerService>();
            _diceServiceMock = new Mock<IDiceService>();
            startingService = new StartingService(_diceServiceMock.Object);
        }





        [Fact]
        public void StartingService_ShouldReRoll_ReturnsTrueIfMoreHighestRollers()
        {
            //Arrange
            
            /*TODO will be changed
            ConcurrentDictionary<Player, int> highestRollers = new();
            highestRollers.TryAdd(new Player(Color.Blue), 4);
            highestRollers.TryAdd(new Player(Color.Green), 4);
            */

            //Act
            var shouldTheyReroll = startingService.ShouldReRoll();

            //Assert
            shouldTheyReroll.Should().BeTrue();
        }

        [Fact]
        public void StartingService_AddAndReplaceStartingRolls_ReplacesTheDictionaryWithNewDictionary()
        {
            /* TODO will be changed
            //Arrange
            _playerServiceMock.Setup(service => service.Players)
                           .Returns(new List<Player>
                           {
                               new(Color.Red),
                               new(Color.Red),
                               new(Color.Red),
                               new(Color.Red)
                           });

            ConcurrentDictionary<Player, int> highestRollers = new();
            highestRollers.TryAdd(new Player(Color.Blue), 4);
            highestRollers.TryAdd(new Player(Color.Green), 4);

            var rolls = startingService.RollAndReturnAllPlayerRolls();

            //Act
            startingService.AddAndReplaceStartingRolls(rolls);

            //Assert
            startingService.StartingRolls.Should().HaveCount(4);
            startingService.AddAndReplaceStartingRolls(highestRollers);
            startingService.StartingRolls.Should().HaveCount(2);
            */
        }

        [Fact]

        public void StartingRollTest()
        {
            //Arrange
            _diceServiceMock.Setup(service => service.RollDice()).Returns(1);

            List<StartingRoll> rolls = new List<StartingRoll>();

            Lobby lobby = new Lobby(new List<Player>()
            {
                new Player(1),
                new Player(2),
                new Player(3),
                new Player(4)
            }) ;

            StartingRoll startingRoll = new StartingRoll(lobby);

            var expectedRoll = new Roll(new Player(1), 1);
            var expectedStartingRolls = new StartingRoll(lobby)
            {
                Rolls = new List<Roll>(){
                    expectedRoll
                }
            };

            //Act
            var result = startingService.StartingRoll(rolls);

            //Assert
            Assert.Equal(result, new List<StartingRoll>() { expectedStartingRolls });
        }
    }
}
