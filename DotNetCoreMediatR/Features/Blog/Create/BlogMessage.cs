using MediatR;

namespace DotNetCoreMediatR.Features.Blog.Create
{
    public class BlogMessage : IRequest<BlogViewModel>
    {
        public BlogViewModel Blog { get; set; }
    }
}
