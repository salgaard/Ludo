using LudoAPI.Models;

namespace LudoAPI.Services
{
    public interface IQueueService
    {
        Queue<Player> Players { get; set; }

        void AddPlayerToQueue(Player player);
        void RemovePlayerFromQueue(Player player);
    }
}