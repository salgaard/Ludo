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
            var rolls = new List<Roll>()
            {
                new Roll(new LobbyPlayer(1), 1),
                new Roll(new LobbyPlayer(2), 2),
                new Roll(new LobbyPlayer(3), 4),
                new Roll(new LobbyPlayer(4), 4),
            };

            //Act
            var shouldTheyReroll = startingService.ShouldReRoll(rolls);

            //Assert
            shouldTheyReroll.Should().BeTrue();
        }

        [Fact]
        public void StartingService_ShouldReRoll_ReturnsFalseIfOnlyOneHighestRoller()
        {
            //Arrange
            var rolls = new List<Roll>()
            {
                new Roll(new LobbyPlayer(1), 1),
                new Roll(new LobbyPlayer(2), 2),
                new Roll(new LobbyPlayer(3), 3),
                new Roll(new LobbyPlayer(4), 4),
            };

            //Act
            var shouldTheyReroll = startingService.ShouldReRoll(rolls);

            //Assert
            shouldTheyReroll.Should().BeFalse();
        }

        [Fact]
        public void StartingService_ShouldReRoll_ReturnsFalseIfTwoLowerDoubles()
        {
            //Arrange
            var rolls = new List<Roll>()
            {
                new Roll(new LobbyPlayer(1), 1),
                new Roll(new LobbyPlayer(2), 2),
                new Roll(new LobbyPlayer(3), 2),
                new Roll(new LobbyPlayer(4), 4),
            };

            //Act
            var shouldTheyReroll = startingService.ShouldReRoll(rolls);

            //Assert
            shouldTheyReroll.Should().BeFalse();
        }

        [Fact]
        public void StartingService_GetRerollers_ShouldReturnTheRerollers()
        {
            //Arrange
            var rolls = new List<Roll>()
            {
                new Roll(new LobbyPlayer(1), 1),
                new Roll(new LobbyPlayer(2), 2),
                new Roll(new LobbyPlayer(3), 4),
                new Roll(new LobbyPlayer(4), 4),
            };

            var expected = new List<LobbyPlayer>();
            expected.Add(rolls[2].Player);
            expected.Add(rolls[3].Player);

            //Act
            var actual = startingService.GetReRollers(rolls);

            //Assert
            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]

        public void StartingRollTest_StartingRoll_ShouldReturnOneStartingRoll()
        {
            //Arrange
            _diceServiceMock.Setup(service => service.RollDice()).Returns(1);

            Lobby lobby = new Lobby(new List<LobbyPlayer>()
            {
                new LobbyPlayer(1),
                new LobbyPlayer(2),
                new LobbyPlayer(3),
                new LobbyPlayer(4)
            }) ;

            Lobby expectedLobby = new Lobby(new List<LobbyPlayer>()
            {
                new LobbyPlayer(1),
                new LobbyPlayer(2),
                new LobbyPlayer(3),
                new LobbyPlayer(4)
            });

            var expectedRoll = new Roll(new LobbyPlayer(1), 1);
            expectedLobby.StartingRolls.Add(expectedRoll);

            //Act
            var result = startingService.StartingRoll(lobby);

            //Assert
            result.Should().BeEquivalentTo(expectedLobby);
        }
    }
}
