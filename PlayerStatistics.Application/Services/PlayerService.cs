using PlayersStatistics.Core.Entities;
using PlayersStatistics.Core.Repositories;

namespace PlayerStatistics.Application
{
    public class PlayerService : IPlayerRepository
    {
        public Task Create(Player player)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Player>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task GetByTeam(string team)
        {
            throw new NotImplementedException();
        }

        public Task SoftDelete(Player player)
        {
            throw new NotImplementedException();
        }

        public Task Update(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
