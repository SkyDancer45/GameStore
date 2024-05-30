<<<<<<< HEAD
﻿namespace GameStore.Api.Dtos
{
    
    public record class CreateGameDto
    {
        public string Name { get; init; }
        public string Genre { get; init; }
        public decimal Price { get; init; }
        public DateOnly ReleaseDate { get; init; }
    }
}
=======
﻿namespace GameStore.Api.Dtos;

public record class CreateGameDtos
{
    int Id;
    string Name;
    string Genre;
    decimal Price;
    DateOnly ReleaseDate;

}
>>>>>>> bf80aa70b2e06e6a97306f598a0e51176e941037
