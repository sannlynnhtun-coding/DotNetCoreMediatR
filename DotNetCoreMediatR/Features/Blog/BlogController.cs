using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreMediatR.Features.Blog
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly ILogger<BlogController> _logger;
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator, ILogger<BlogController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Create(BlogViewModel blogViewModel)
        {
            var response = await _mediator.Send(new BlogMessage { Blog = blogViewModel });
            return Ok(response);
        }
    }
}
