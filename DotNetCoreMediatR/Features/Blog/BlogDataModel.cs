using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreMediatR.Features.Blog
{
    [Table("Tbl_Blog")]
    public class BlogDataModel
    {
        [Key]
        [Column("Blog_Id")]
        public int Blog_Id { get; set; }

        [Column("Blog_Title")]
        public string Blog_Title { get; set; }

        [Column("Blog_Author")]
        public string Blog_Author { get; set; }

        [Column("Blog_Content")]
        public string Blog_Content { get; set; }
    }
}
