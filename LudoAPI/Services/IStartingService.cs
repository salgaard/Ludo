using LudoAPI.Models;

namespace LudoAPI.Services
{
    public interface IStartingService
    {
        bool ShouldReRoll();

        void AddAndReplaceStartingRolls();

        List<StartingRoll> StartingRoll();

    }
}
