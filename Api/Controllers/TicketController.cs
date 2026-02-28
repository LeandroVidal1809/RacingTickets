using Application;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly TicketService _service;

        public TicketsController(TicketService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Purchase([FromBody] PurchaseRequest request)
        {
            var ticket = _service.Purchase(request.MatchId, request.UserId, request.Sector);
            return Ok(ticket);
        }

        [HttpGet("{userId}")]
        public IActionResult GetByUser(Guid userId)
        {
            return Ok(_service.GetByUser(userId));
        }
    }
}
