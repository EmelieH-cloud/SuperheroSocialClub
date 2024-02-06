using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Managers;
using SuperheroSocialClub.Models;


namespace SuperheroSocialClub.Pages.Superhero
{
    public class IndexModel : PageModel
    {
        public List<SuperheroModel> Superheroes { get; set; }
        public void OnGet()
        {
            Superheroes = SuperheroManager.Superheroes;
        }
    }
}
