using artHouse.Models;
using artHouse.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace artHouse.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {

        public VideosController(JsonFileVideoService videoService)
        {

            this.VideoService = videoService;

        }

        public JsonFileVideoService VideoService { get; }

        [HttpGet]
        public IEnumerable<Video> Get()
        {

            return VideoService.GetVideos();

        }

        //[HttpPatch] "[FromBody]"
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery]string VideoId,
            [FromQuery] int Rating)
        {
            VideoService.AddRating(VideoId, Rating);
            return Ok();
        }
    }
}
