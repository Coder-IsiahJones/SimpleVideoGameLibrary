using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleVideoGameLibrary.Server.Data;
using SimpleVideoGameLibrary.Shared;

namespace SimpleVideoGameLibrary.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoGameController : ControllerBase
    {
        private readonly DataContext _context;

        public VideoGameController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetAllVideoGames()
        {
            var list = await _context.VideoGames.OrderBy(game => game.ReleaseYear).ToListAsync();

            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetVideoGame(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var game = await _context.VideoGames.FindAsync(id);

            if (game == null)
            {
                return NotFound("This video game does not exist!");
            }

            return Ok(game);
        }


        [HttpPost]
        public async Task<ActionResult<List<VideoGame>>> CreateVideoGame(VideoGame videoGame)
        {
            _context.VideoGames.Add(videoGame);
            await _context.SaveChangesAsync();

            return Ok(videoGame);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<VideoGame>>> UpdateVideoGame(int id, VideoGame videoGame)
        {
            if (id != videoGame.Id)
            {
                return BadRequest();
            }

            var game = await _context.VideoGames.FindAsync(id);

            if (game == null)
            {
                return NotFound("This video game does not exist!");
            }

            game.Title = videoGame.Title;
            game.ReleaseYear = videoGame.ReleaseYear;
            game.Publisher = videoGame.Publisher;

            _context.VideoGames.Update(game);
            await _context.SaveChangesAsync();

            return Ok(videoGame);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<VideoGame>> DeleteVideoGame(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var game = await _context.VideoGames.FindAsync(id);

            if (game == null)
            {
                return NotFound("This video game does not exist!");
            }

            _context.VideoGames.Remove(game);
            await _context.SaveChangesAsync();

            return Ok(game);
        }
    }
}
