namespace SuperheroSocialClub.Managers

{
    public static class SuperheroManager
    {

        public static List<Superhero> Superheroes { get; } = new List<Superhero>
    {
        new Superhero { Id = 1, Name = "Superman", SecretIdentity = "Clark Kent", SuperPower = "Flight, Super Strength, Heat Vision" },
        new Superhero { Id = 2, Name = "Batman", SecretIdentity = "Bruce Wayne", SuperPower = "Intelligence, Wealth, Martial Arts" },
        new Superhero { Id = 3, Name = "Wonder Woman", SecretIdentity = "Diana Prince", SuperPower = "Super Strength, Lasso of Truth" },
        new Superhero { Id = 4, Name = "Spider-Man", SecretIdentity = "Peter Parker", SuperPower = "Wall-Crawling, Spider-Sense, Web Shooting" },
        new Superhero { Id = 5, Name = "Captain America", SecretIdentity = "Steve Rogers", SuperPower = "Super Soldier Serum, Shield" },
        new Superhero { Id = 6, Name = "Iron Man", SecretIdentity = "Tony Stark", SuperPower = "Powered Armor Suit, Genius Intellect" },
        new Superhero { Id = 7, Name = "Thor", SuperPower = "God of Thunder, Mjolnir" },
        new Superhero { Id = 8, Name = "Hulk", SecretIdentity = "Bruce Banner", SuperPower = "Super Strength, Invulnerability" },
        new Superhero { Id = 9, Name = "Black Widow", SecretIdentity = "Natasha Romanoff", SuperPower = "Espionage, Martial Arts" },
        new Superhero { Id = 10, Name = "Flash", SecretIdentity = "Barry Allen", SuperPower = "Super Speed" },
        new Superhero { Id = 11, Name = "Green Lantern", SecretIdentity = "Hal Jordan", SuperPower = "Power Ring" },
        new Superhero { Id = 12, Name = "Aquaman", SecretIdentity = "Arthur Curry", SuperPower = "Atlantean Physiology, Marine Telepathy" },
        new Superhero { Id = 13, Name = "Black Panther", SecretIdentity = "T'Challa", SuperPower = "Enhanced Senses, Vibranium Suit" },
        new Superhero { Id = 14, Name = "Doctor Strange", SecretIdentity = "Stephen Strange", SuperPower = "Mystic Arts, Time Manipulation" },
        new Superhero { Id = 15, Name = "Wolverine", SecretIdentity = "Logan", SuperPower = "Regeneration, Adamantium Claws" },
        new Superhero { Id = 16, Name = "Storm", SecretIdentity = "Ororo Munroe", SuperPower = "Weather Manipulation" },
        new Superhero { Id = 17, Name = "Supergirl", SecretIdentity = "Kara Zor-El", SuperPower = "Flight, Heat Vision" },
        new Superhero { Id = 18, Name = "Green Arrow", SecretIdentity = "Oliver Queen", SuperPower = "Master Archer, Martial Arts" },
        new Superhero { Id = 19, Name = "Cyborg", SecretIdentity = "Victor Stone", SuperPower = "Cybernetic Enhancements" },
        new Superhero { Id = 20, Name = "Ant-Man", SecretIdentity = "Scott Lang", SuperPower = "Size Manipulation, Insect Communication" }
    };
    }
}
