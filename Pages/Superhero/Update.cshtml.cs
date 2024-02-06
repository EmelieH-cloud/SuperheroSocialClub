using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Managers;
using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Pages.Superhero
{
    public class UpdateModel : PageModel
    {
        public SuperheroModel? Superhero { get; set; }
        public void OnGet(int id)
        {
            Superhero = SuperheroManager.Superheroes.FirstOrDefault(a => a.Id == id);

        }

        public void OnPost()
        {
            // Retrieve the form values submitted by the user
            string name = Request.Form["Name"];
            string superpower = Request.Form["SuperPower"];
            string secretIdentity = Request.Form["SecretIdentity"];

            // Update the Superhero object properties
            Superhero.Name = name;
            Superhero.SuperPower = superpower;
            Superhero.SecretIdentity = secretIdentity;

        }
    }
}
