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
            startingService = new StartingService(_playerServiceMock.Object, _diceServiceMock.Object);
        }

        [Fact]
        public void StartingService_RollAndReturnAllPlayerRolls_ReturnsAllRolls()
        {
            //Arrange
            _playerServiceMock.Setup(service => service.Players)
                           .Returns(new List<Player> 
                           { 
                               new(1),
                               new(2),
                               new(3),
                               new(4)
                           });
            //Act
            var rolls = startingService.RollAndReturnAllPlayerRolls();

            //Assert
            rolls.Should().HaveCount(4);
        }

        [Fact]
        public void StartingService_FindAndReturnHighestRolls_ReturnsHighestRollers()
        {
            //Arrange
            ConcurrentDictionary<Player, int> startingRolls = new();
            startingRolls.TryAdd(new Player( 1), 1);
            startingRolls.TryAdd(new Player(2), 2);
            startingRolls.TryAdd(new Player(3), 4);
            startingRolls.TryAdd(new Player(4), 4);

            //Act
            var highestRolls = startingService.FindAndReturnHighestRolls();

            //Assert
            highestRolls.Should().HaveCount(2);
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
    }
}
