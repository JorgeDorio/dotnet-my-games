namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        return Games.Where(game => game.DeveloperStudio == gameStudio.Id).ToList();
    }

    public List<Game> GetGamesPlayedBy(Player player)
    {
        return Games.Where(game => game.Players.Contains(player.Id)).ToList();
    }

    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        return Games.Where(game => playerEntry.GamesOwned.Contains(game.Id)).ToList();
    }
}
