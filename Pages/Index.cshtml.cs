using artHouse.Models;
using artHouse.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace artHouse.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileVideoService VideoService;

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileVideoService videoService)
        {
            _logger = logger;
            VideoService = videoService;
            Videos = VideoService.GetVideos(); 
        }

        public IEnumerable<Video> Videos { get; private set; }

        public void OnGet()
        {
            Videos = VideoService.GetVideos();
        }
    }
}