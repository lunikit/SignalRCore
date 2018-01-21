using System.Collections.Generic;
using Chater.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Chater.Controllers
{
    [Produces("application/json")]
    [Route("api/Chat")]
    public class ChatController : Controller
    {
        private readonly IHubContext<ChatHub> _context;

        public ChatController(IHubContext<ChatHub> context)
        {
            _context = context;
        }

        // GET: api/Chat
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/Chat/5
        [HttpPost("{message}", Name = "Post")]
        public string Post(string message)
        {
            this._context.Clients.All.InvokeAsync("Send", message);

            return message;
        }
    }
}
