using System.Collections.Generic;
using System.Threading.Tasks;
using GameStoreNew.Models;

namespace GameStoreNew.IService
{
    public interface IGameService
    {
        Task<List<Game>> GetGames();
        Task<Game> GetGame(int GameId);
        Task AddGame(Game game);
        Task UpdateGame(Game game);
        Task DeleteGame(int GameId);
    }
}
