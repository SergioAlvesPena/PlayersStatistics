using PlayersStatistics.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersStatistics.Core.Repositories
{
    public interface IPlayerRepository
    {
        Task Create(Player player);
        Task Update(Player player);
        Task SoftDelete(Player player);
        Task GetByName(string name);
        Task<IEnumerable<Player>> GetAll();
        Task GetByTeam(string team);
    }
}
