using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CBoardings.WebApp.Pages
{
    [Authorize]
    public class BoardedModel : PageModel
    {
        private readonly IBoardingData _boardingData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Boarding Boarding { get; set; }
        public IEnumerable<SelectListItem> CompassNS { get; set; }
        public IEnumerable<SelectListItem> CompassEW { get; set; }
        public BoardedModel(IBoardingData boardingData, IHtmlHelper htmlHelper)
        {
            _boardingData = boardingData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet()
        {
            CompassNS = htmlHelper.GetEnumSelectList<CompassNS>();
            CompassEW = htmlHelper.GetEnumSelectList<CompassEW>();
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
            return RedirectToPage("../Index");
        }
    }
}
