using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DotNetCoreMediatR.Features.Blog.Create
{
    public class BlogEventHandler : IRequestHandler<BlogMessage, BlogViewModel>
    {
        private readonly AppDbContext _appDbContext;

        public BlogEventHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<BlogViewModel> Handle(BlogMessage request, CancellationToken cancellationToken)
        {
            BlogDataModel blogDataModel = new BlogDataModel()
            {
                Blog_Title = request.Blog.Title,
                Blog_Author = request.Blog.Author,
                Blog_Content = request.Blog.Content,
            };
            await _appDbContext.Blogs.AddAsync(blogDataModel);
            await _appDbContext.SaveChangesAsync();
            request.Blog.Id = blogDataModel.Blog_Id;

            return request.Blog;
        }
    }

    //public class BlogNotificationEventHandler : IRequestHandler<BlogMessage, BlogViewModel>
    //{
    //    private readonly ILogger<BlogNotificationEventHandler> _logger;

    //    public BlogNotificationEventHandler(ILogger<BlogNotificationEventHandler> logger)
    //    {
    //        _logger = logger;
    //    }

    //    public Task<BlogViewModel> Handle(BlogMessage request, CancellationToken cancellationToken)
    //    {
    //        _logger.LogInformation(JsonConvert.SerializeObject(request));
    //        return Task.FromResult(request.Blog);
    //    }
    //}
}
