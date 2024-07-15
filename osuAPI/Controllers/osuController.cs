    using Microsoft.AspNetCore.Mvc;
using osu_BL;

namespace osuAPI.Controllers
{
    [ApiController]
    [Route("api/beatmap")]
    public class osuController : ControllerBase
    {
        BeatMapGetServices getServices;
        BeatMapTransactionServices transactionServices;

        public osuController()
        {
            getServices = new BeatMapGetServices();
            transactionServices = new BeatMapTransactionServices();
        }

        [HttpGet]
        public IEnumerable<osuAPI.BeatMap> GetBeatMap()
        {
            var beatmaps = getServices.GetAllBeatMaps();

            List<osuAPI.BeatMap> beat = new List<osuAPI.BeatMap>();

            foreach (var song in beatmaps)
            {
                beat.Add(new osuAPI.BeatMap { title = song.title, artist = song.artist });
            }
            return beat;
        }

        [HttpPost]
        public JsonResult AddSong(BeatMap request)
        {
            var result = transactionServices.CreateBeatMap(request.title, request.artist);

            return new JsonResult(result);
        }

        [HttpPatch]
        public JsonResult UpdateSong(BeatMap request)
        {
            var result = transactionServices.UpdateSongMap(request.title, request.artist);

            return new JsonResult(result);
        }

        [HttpDelete]
        public JsonResult DeleteSong(osuAPI.BeatMap request)    
        {

            var delete = new ozuModel.BeatMap
            {
                title = request.title

            };

            var result = transactionServices.DeleteSongMap(delete);

            return new JsonResult(result);
        }
    }
}