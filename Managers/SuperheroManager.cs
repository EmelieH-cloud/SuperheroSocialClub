namespace SuperheroSocialClub.Managers
{
    public static class SuperheroManager
    {
        public static List<SuperheroModel> Superheroes { get; } = new List<SuperheroModel>
    {
        new SuperheroModel { Id = 1, Name = "Superman", SecretIdentity = "Clark Kent", SuperPower = "Flight, Super Strength, Heat Vision" },
        new SuperheroModel { Id = 2, Name = "Batman", SecretIdentity = "Bruce Wayne", SuperPower = "Intelligence, Wealth, Martial Arts" },
        new SuperheroModel { Id = 3, Name = "Wonder Woman", SecretIdentity = "Diana Prince", SuperPower = "Super Strength, Lasso of Truth" },
        new SuperheroModel { Id = 4, Name = "Spider-Man", SecretIdentity = "Peter Parker", SuperPower = "Wall-Crawling, Spider-Sense, Web Shooting" },
        new SuperheroModel { Id = 5, Name = "Captain America", SecretIdentity = "Steve Rogers", SuperPower = "Super Soldier Serum, Shield" },
        new SuperheroModel { Id = 6, Name = "Iron Man", SecretIdentity = "Tony Stark", SuperPower = "Powered Armor Suit, Genius Intellect" },
        new SuperheroModel { Id = 7, Name = "Thor", SuperPower = "God of Thunder, Mjolnir" },
        new SuperheroModel { Id = 8, Name = "Hulk", SecretIdentity = "Bruce Banner", SuperPower = "Super Strength, Invulnerability" },
        new SuperheroModel { Id = 9, Name = "Black Widow", SecretIdentity = "Natasha Romanoff", SuperPower = "Espionage, Martial Arts" },
        new SuperheroModel { Id = 10, Name = "Flash", SecretIdentity = "Barry Allen", SuperPower = "Super Speed" },
        new SuperheroModel { Id = 11, Name = "Green Lantern", SecretIdentity = "Hal Jordan", SuperPower = "Power Ring" },
        new SuperheroModel { Id = 12, Name = "Aquaman", SecretIdentity = "Arthur Curry", SuperPower = "Atlantean Physiology, Marine Telepathy" },
        new SuperheroModel { Id = 13, Name = "Black Panther", SecretIdentity = "T'Challa", SuperPower = "Enhanced Senses, Vibranium Suit" },
        new SuperheroModel { Id = 14, Name = "Doctor Strange", SecretIdentity = "Stephen Strange", SuperPower = "Mystic Arts, Time Manipulation" },
        new SuperheroModel { Id = 15, Name = "Wolverine", SecretIdentity = "Logan", SuperPower = "Regeneration, Adamantium Claws" },
        new SuperheroModel { Id = 16, Name = "Storm", SecretIdentity = "Ororo Munroe", SuperPower = "Weather Manipulation" },
        new SuperheroModel { Id = 17, Name = "Supergirl", SecretIdentity = "Kara Zor-El", SuperPower = "Flight, Heat Vision" },
        new SuperheroModel { Id = 18, Name = "Green Arrow", SecretIdentity = "Oliver Queen", SuperPower = "Master Archer, Martial Arts" },
        new SuperheroModel { Id = 19, Name = "Cyborg", SecretIdentity = "Victor Stone", SuperPower = "Cybernetic Enhancements" },
        new SuperheroModel { Id = 20, Name = "Ant-Man", SecretIdentity = "Scott Lang", SuperPower = "Size Manipulation, Insect Communication" }
    };
    }
}
