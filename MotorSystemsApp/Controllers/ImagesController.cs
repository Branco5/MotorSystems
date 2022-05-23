using Microsoft.AspNetCore.Mvc;
using MotorSystemsApp.Data;
using System.Net.Http.Headers;
using Azure.Storage.Blobs;
using System.ComponentModel;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotorSystemsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        // GET: api/<ImagesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ImagesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ImagesController>
        //[HttpPost]

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> Upload()
        {
            var blobConnectionString = "DefaultEndpointsProtocol=https;AccountName=blobstoragemotorsystems;AccountKey=pjkq766wmogwzQRsSDS69ooRtLZMWemdBKDccYRgqEvw68U7EL0/7OYJ8ouLjdTUpefPzWa3XDhaOEqYEKglFA==;EndpointSuffix=core.windows.net";
            var blobContainerName = "images";

            var container = new BlobContainerClient(blobConnectionString, blobContainerName);

            try
            {
                var fileContent = Request.Form.Files["file"];
                
                var pathToSave = "https://blobstoragemotorsystems.blob.core.windows.net/images/";

                if (fileContent.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(fileContent.ContentDisposition).FileName.Trim('"');

                    var blob = container.GetBlobClient(fileName);

                    var blobPath = pathToSave + fileName;

                    
                    var localStorePath = Path.Combine(Directory.GetCurrentDirectory(), "Images");

                    Directory.CreateDirectory(localStorePath);
                    var filePath = Path.Combine(localStorePath, fileName);
                    
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        fileContent.CopyTo(stream);
                    }
                    using (var stream = System.IO.File.OpenRead(filePath))
                    {
                        await blob.UploadAsync(stream);
                    }

                    return Ok(new { blobPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }     
        

        // PUT api/<ImagesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ImagesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
