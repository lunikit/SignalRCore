using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chater.Controllers
{
    [Produces("application/json")]
    [Route("api/Chat")]
    public class ChatController : Controller
    {
        // GET: api/Chat
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Chat/5
        [HttpGet("{message}", Name = "Get")]
        public string Get(string message)
        {
            return message;
        }
    }
}
