using GameCatalog.Models;

namespace GameCatalog
{
    public static class GameClient
    {
        private static readonly List<Game> games = new()
        {
            new Game()
            {
                Id = 1,
                Name = "Sreet Frighter II",
                Genre = "Fighting",
                Price = 20.99M,
                ReleaseDate = new DateTime(2020, 01, 04)

            },
            new Game()
            {
                Id = 2,
                Name = "Super Mario",
                Genre = "fantasy",
                Price = 10.99M,
                ReleaseDate = new DateTime(1988, 09, 25)

            },
            new Game()
            {
                Id = 3,
                Name = "Fifa 24",
                Genre = "Sports",
                Price = 25.99M,
                ReleaseDate = new DateTime(2023, 05, 05)

            }

        };

        public static Game[] GetGames()
        {
            return games.ToArray();
        }

        public static void AddGame(Game game)
        {
            game.Id = games.Max(game => game.Id) + 1;
            games.Add(game);
        }

        public static Game GetGame(int id)
        {
            return games.Find(game => game.Id == id) ?? throw new Exception("cannot find the game");
        }

        public static void UpdateGame(Game updatedGame)
        {
            Game existingGame = GetGame(updatedGame.Id);
            existingGame.Genre = updatedGame.Genre;
            existingGame.Name = updatedGame.Name;
            existingGame.Price = updatedGame.Price;
            existingGame.ReleaseDate = updatedGame.ReleaseDate;
        }

        public static void DeleteGame(int id)
        {
            Game existingGame = GetGame(id);
            games.Remove(existingGame);

        }
    }
}
