using LudoAPI.Models;
using LudoAPI.Repositories;
using FluentAssertions;
using Xunit;

namespace LudoTest.RepoTests
{
    public class LobbyRepoTests
    {
        [Fact]
        public void Add_ShouldAddLobbyToList()
        {
            // Arrange
            var repository = new LobbyRepository();
            var players = new List<LobbyPlayer> { new LobbyPlayer(1), new LobbyPlayer(2) };
            var lobby = new Lobby(players, 1);

            // Act
            repository.AddNewLobby(lobby);

            // Assert
            repository.Lobbies.Should().Contain(lobby);
        }

        [Fact]
        public void Get_ShouldReturnLobbyById()
        {
            // Arrange
            var repository = new LobbyRepository();
            var players = new List<LobbyPlayer> { new LobbyPlayer(1), new LobbyPlayer(2) };
            var lobby = new Lobby(players, 1);
            repository.AddNewLobby(lobby);

            // Act
            var result = repository.Get(1);

            // Assert
            result.Should().Be(lobby);
        }

        [Fact]
        public void GetNextId_ShouldReturnNextId()
        {
            // Arrange
            var repository = new LobbyRepository();
            var players1 = new List<LobbyPlayer> { new LobbyPlayer(1), new LobbyPlayer(2) };
            var lobby1 = new Lobby(players1, 1);
            repository.AddNewLobby(lobby1);

            var players2 = new List<LobbyPlayer> { new LobbyPlayer(3), new LobbyPlayer(4) };
            var lobby2 = new Lobby(players2, 2);
            repository.AddNewLobby(lobby2);

            // Act
            var nextId = repository.GetNextId();

            // Assert
            nextId.Should().Be(3);
        }
    }
}
