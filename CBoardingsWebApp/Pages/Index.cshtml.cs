using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CBoardingsWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBoardingData _boardingData;
        public IEnumerable<Boarding> Boardings { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IBoardingData boardingData)
        {
            _logger = logger;
            _boardingData = boardingData;
        }
        public void OnGet()
        {
            _logger.LogInformation("Index loaded");
            Boardings = _boardingData.GetBoardings();
        }
    }
}