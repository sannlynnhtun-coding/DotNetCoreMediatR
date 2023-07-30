using MediatR;

namespace DotNetCoreMediatR.Features.Blog
{
    public class BlogGetMessage : IRequest<BlogListModel>
    {
        public PageSettingModel PageSetting { get; set; }
    }
}
