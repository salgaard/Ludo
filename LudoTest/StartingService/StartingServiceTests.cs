using FluentAssertions;
using LudoAPI.Models;
using LudoAPI.Services;
using Moq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                               new Player(ColorType.Red, new List<Piece>()),
                               new Player(ColorType.Red, new List<Piece>()),
                               new Player(ColorType.Red, new List<Piece>()),
                               new Player(ColorType.Red, new List<Piece>())
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
            startingRolls.TryAdd(new Player(), 1);
            startingRolls.TryAdd(new Player(), 2);
            startingRolls.TryAdd(new Player(), 4);
            startingRolls.TryAdd(new Player(), 4);

            //Act
            var highestRolls = startingService.FindAndReturnHighestRolls();

            //Assert
            highestRolls.Should().HaveCount(2);
        }

        [Fact]
        public void StartingService_ShouldReRoll_ReturnsTrueIfMoreHighestRollers()
        {
            //Arrange
            ConcurrentDictionary<Player, int> highestRollers = new();
            highestRollers.TryAdd(new Player(), 4);
            highestRollers.TryAdd(new Player(), 4);

            //Act
            var shouldTheyReroll = startingService.ShouldReRoll();

            //Assert
            shouldTheyReroll.Should().BeTrue();
        }

        [Fact]
        public void StartingService_AddAndReplaceStartingRolls_ReplacesTheDictionaryWithNewDictionary()
        {
            //Arrange
            _playerServiceMock.Setup(service => service.Players)
                           .Returns(new List<Player>
                           {
                               new Player(ColorType.Red, new List<Piece>()),
                               new Player(ColorType.Red, new List<Piece>()),
                               new Player(ColorType.Red, new List<Piece>()),
                               new Player(ColorType.Red, new List<Piece>())
                           });

            ConcurrentDictionary<Player, int> highestRollers = new();
            highestRollers.TryAdd(new Player(), 4);
            highestRollers.TryAdd(new Player(), 4);

            var rolls = startingService.RollAndReturnAllPlayerRolls();

            //Act
            startingService.AddAndReplaceStartingRolls(rolls);

            //Assert
            startingService.StartingRolls.Should().HaveCount(4);
            startingService.AddAndReplaceStartingRolls(highestRollers);
            startingService.StartingRolls.Should().HaveCount(2);
        }
    }
}
