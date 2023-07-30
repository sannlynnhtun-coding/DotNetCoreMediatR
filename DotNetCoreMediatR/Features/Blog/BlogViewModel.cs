namespace DotNetCoreMediatR.Features.Blog
{
    public class BlogViewModel
    {
        public int Id { get; set; } 
        public string Title { get; set; }   
        public string Author { get; set; }
        public string Content { get; set; }
    }

    public class BlogListModel
    {
        public List<BlogViewModel> Data { get; set; }
    }
}