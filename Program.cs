using GameStore.Api.Dtos;
//using System;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<GameDto> games = [new(1, "COD", "Action", 50.0M, new DateOnly(2010, 09, 30)), new(2, "Witcher 3", "Fantasy", 52.0M, new DateOnly(2010, 09, 29))];
app.MapGet("games", () => games);

<<<<<<< HEAD
app.MapGet("/", () => "Hellosasadasdda World!");
app.MapPost("games", (CreateGameDto newGame) =>
{
    GameDto game = new GameDto(
        games.Count + 1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.ReleaseDate
        );
    games.Add(game);
    return Results.Created();
});
app.MapPut("games/{id}", (int id, UpdateGameDto newGame) =>
        {
            GameDto replacementGame = new GameDto(
                id,
                newGame.Name,
                newGame.Genre,
                newGame.Price,
                newGame.ReleaseDate
                );
            games[id - 1] = replacementGame;
            return Results.Accepted();
        });
app.MapDelete("games/{id}", (int id) =>
{
    games.RemoveAt(id-1);
});
=======
// app.MapGet("/", () => "Hellosasadasdda World!");
>>>>>>> bf80aa70b2e06e6a97306f598a0e51176e941037
Console.Write("Mooo");
//GET /games/1
app.MapGet("games/{id}", (int id) => games.Find(game => game.Id == id));
app.MapPost("games",(CreateGameDtos newGame)=>{

});
app.Run();
