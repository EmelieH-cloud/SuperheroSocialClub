namespace SuperheroSocialClub.Models
{
    public class SuperheroModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Image { get; set; }

        public string? Superpower { get; set; }

        public string? SecretIdentity { get; set; }
    }
}
