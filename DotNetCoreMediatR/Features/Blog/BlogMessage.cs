using MediatR;

namespace DotNetCoreMediatR.Features.Blog
{
    public class BlogMessage : IRequest<BlogViewModel>
    {
        public BlogViewModel Blog { get; set; }
    }
}
