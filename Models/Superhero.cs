﻿namespace SuperheroSocialClub.Models
{
    public class Superhero
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Image { get; set; }

        public string? SuperPower { get; set; }

        public string? SecretIdentity { get; set; }
    }
}
