using System.Net;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IPhoneApi.Controllers
{
    [Route("api/[controller]")]
    public class ImagesController : Controller
    {

        // GET api/images/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            
            byte[] imageData;

            var msg = Messages.ToList().FirstOrDefault(d => d.Id == id);
            
            if (msg == null) return NotFound();

            using (var stream = typeof(ImagesController).Assembly.GetManifestResourceStream(msg.ImageName))
            {
                if (stream == null)
                {
                    return NotFound();
                }

                using (var memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    imageData = memoryStream.ToArray();
                }
            }

            return File(imageData, "image/jpeg");
        }


    }
}

