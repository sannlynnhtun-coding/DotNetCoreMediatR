using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMediatR.MultipleNotification.Features.Notification
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Send(NotificationModel notificationModel)
        {
            await _mediator.Publish(new NotificationMessage { Message = notificationModel.Message });
            return Ok();
        }
    }
}
