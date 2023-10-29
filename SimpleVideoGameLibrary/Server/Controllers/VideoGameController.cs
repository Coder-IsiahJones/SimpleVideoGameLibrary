using Microsoft.AspNetCore.Mvc;
using SimpleVideoGameLibrary.Shared;

namespace SimpleVideoGameLibrary.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        public async Task<ActionResult<List<VideoGame>>> GetAllVideoGames()
        {
            var list = new List<VideoGame> {
                new VideoGame { Id = 1, Title = "Super Mario Bros.", Publisher = "Nintendo", ReleaseYear = 1985 },
                new VideoGame { Id = 2, Title = "The Legend of Zelda", Publisher = "Nintendo", ReleaseYear = 1986 },
            };

            return Ok(list);
        }
    }
}
