
using Projects.Core.Entities.Base;

namespace Projects.Core.Entities
{
    public class Commentary : BaseEntity
    {
        public string Content { get; set; }
        public int Author { get; set; }
        public Commentary? ParrentCommentary { get; set; }
        public List<Commentary> SubComments { get; set; }

    }
}
