
namespace Projects.Core.Entities
{
    public class Release
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public List<Task> TaskList { get; set; }
        Project Project { get; set; }

    }
}
