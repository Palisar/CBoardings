using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CBoardings.WebApp.Pages.Navy
{
    public class DeleteModel : PageModel
    {
        public DeleteModel(IBoardingData boardingData)
        {
            BoardingData = boardingData;
        }
        public Boarding Boarding { get; set; }
        public IBoardingData BoardingData { get; }

        public IActionResult OnGet(Guid boardingId)
        {
            Boarding = BoardingData.GetBoardingById(boardingId);
            if (Boarding == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost(Guid boardingId)
        {
            var boarding = BoardingData.Delete(boardingId);
            BoardingData.Commit();

            if (boarding == null)
            {
                return RedirectToPage("./NotFound");
            }
            TempData["Message"] = $"{boarding.Position} deleted";
            return RedirectToPage("/Index");
        }
    }
}
