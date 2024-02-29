using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IPhoneApi.Controllers
{
    [Route("api/[controller]")]
    public class MessagesController : Controller
    {
        // GET: api/message
        [HttpGet]
        public IEnumerable<Message> Get()
        {
            return Messages.ToList();
        }

        // GET api/message/5
        [HttpGet("{id}")]
        public Message? Get(int id)
        {
            return Messages.ToList().FirstOrDefault(d=>d.Id==id);
        }


    }
}

