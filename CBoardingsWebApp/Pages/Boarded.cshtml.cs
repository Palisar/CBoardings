using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CBoardings.WebApp.Pages
{
    public class BoardedModel : PageModel
    {
        private readonly IBoardingData _boardingData;
        [BindProperty]
        public Boarding Boarding { get; set; }
        public BoardedModel(IBoardingData boardingData)
        {
            _boardingData = boardingData;;
        }
        public IActionResult OnGet()
        {
            Boarding = new Boarding();
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _boardingData.AddBoarding(Boarding);
            return RedirectToPage("./Index");
            
        }
    }
}
