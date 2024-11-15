using Amazon.S3;
using Microsoft.AspNetCore.Mvc;
using osu_BL;
using Amazon.S3.Transfer;
using Amazon.S3.Model;

namespace osuAPI.Controllers
{
    [ApiController]
    [Route("api/beatmap")]
    public class osuController : ControllerBase
    {
        BeatMapGetServices getServices;
        BeatMapTransactionServices transactionServices;

        private readonly IAmazonS3 _s3client;
        private readonly ILogger<osuController> _logger;

        public osuController(ILogger<osuController> logger,
            IAmazonS3 s3Client)
        {
            getServices = new BeatMapGetServices();
            transactionServices = new BeatMapTransactionServices();
            _logger = logger;
            _s3client = s3Client;
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

        [HttpPost("create beatmap")]
        public JsonResult AddSong(BeatMap request)
        {
            var result = transactionServices.CreateBeatMap(request.title, request.artist);

            return new JsonResult(result);
        }

        [HttpPost("upload files")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length <= 0)
            {
                return BadRequest("An unexpected error has occurred.");
            }
            string bucketName = "sldalcoriza";
            string fileKey = "background: " + file.FileName;
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                var putRequest = new Amazon.S3.Model.PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = fileKey,
                    InputStream = memoryStream
                };

                var response = await _s3client.PutObjectAsync(putRequest);
                if (response.HttpStatusCode == System.Net.HttpStatusCode.OK)
                {
                    return Ok("Your file has been successfully uploaded to your bucket.");
                }

                else
                {
                    return StatusCode(500, "A problem with uploading has occurred.");
                }
            }
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