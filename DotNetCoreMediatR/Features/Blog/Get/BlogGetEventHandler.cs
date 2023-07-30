using MediatR;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DotNetCoreMediatR.Features.Blog
{
    public class BlogGetEventHandler : IRequestHandler<BlogGetMessage, BlogListModel>
    {
        private readonly AppDbContext _appDbContext;

        public BlogGetEventHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<BlogListModel> Handle(BlogGetMessage request, CancellationToken cancellationToken)
        {
            int skipRow = (request.PageSetting.PageNo - 1) * request.PageSetting.PageSize;
            var result = await _appDbContext.Blogs.Skip(skipRow).Take(request.PageSetting.PageSize)
                .ToListAsync();
            var lst = result.Select(x => new BlogViewModel
            {
                Author = x.Blog_Author,
                Content = x.Blog_Content,
                Id = x.Blog_Id,
                Title = x.Blog_Title,
            }).ToList();
            return new BlogListModel { Data = lst };
        }
    }
}
