using System.Collections.Generic;
using System.Threading.Tasks;
using GameStoreNew.Models;
using GameStoreNew.IService;
using MongoDB.Driver;
using MongoDB.Bson;

namespace GameStoreNew.Service
{
    public class GameService : IGameService
    {
        private readonly IMongoCollection<Game> _gameCollection;

        public GameService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("GameStore");
            _gameCollection = database.GetCollection<Game>("Games");
        }

        public async Task<List<Game>> GetGames()
        {
            return await _gameCollection.Find(FilterDefinition<Game>.Empty).ToListAsync();
        }

        public async Task<Game> GetGame(int GameId)
        {
            return await _gameCollection.Find(game => game.GameId == GameId).FirstOrDefaultAsync()
                   ?? throw new Exception("Could not find game!");
        }

        public async Task AddGame(Game game)
        {
            Console.WriteLine("Came here 2");
            game.GameId = await GetNextGameId();
            await _gameCollection.InsertOneAsync(game);
            Console.WriteLine("Inserted new student. Name: " + game.Name);
        }

        public async Task UpdateGame(Game updatedGame)
        {
            var game = await _gameCollection.Find(x => x.GameId == updatedGame.GameId).FirstOrDefaultAsync();
            if (game == null)
            {
                throw new Exception("Could not find game!");
            }

            game.Name = updatedGame.Name;
            game.Genre = updatedGame.Genre;
            game.Price = updatedGame.Price;
            game.ReleaseDate = updatedGame.ReleaseDate;

            await _gameCollection.ReplaceOneAsync(x => x.GameId == updatedGame.GameId, game);
        }

        public async Task DeleteGame(int GameId)
        {
            var result = await _gameCollection.DeleteOneAsync(game => game.GameId == GameId);
            if (result.DeletedCount == 0)
            {
                throw new Exception("Could not find game to delete!");
            }
        }

        private async Task<int> GetNextGameId()
        {
            var games = await _gameCollection.Find(FilterDefinition<Game>.Empty).SortByDescending(g => g.GameId).FirstOrDefaultAsync();
            return games == null ? 1 : games.GameId + 1;
        }
    }
}
