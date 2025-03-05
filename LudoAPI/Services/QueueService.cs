using LudoAPI.Models;

namespace LudoAPI.Services
{
    public class QueueService : IQueueService
    {

        public QueueService()
        {
        }

        public Queue<Player> Players { get; set; }

        public void AddPlayerToQueue(Player player)
        {
            // tilføj player til Players list
            throw new NotImplementedException();
        }



        public void RemovePlayerFromQueue(Player player)
        {
            //når det er players tur
            throw new NotImplementedException();

        }




    }
}
