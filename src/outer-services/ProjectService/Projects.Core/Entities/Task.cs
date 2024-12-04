using Projects.Core.Entities.Base;

namespace Projects.Core.Entities
{
    public class Task : BaseEntity
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Staus { get; set; }
        public Priority Priority { get; set; }
        public int Creator {  get; set; }
        public int Worker { get; set; }
        public int Inspector { get; set; }
        public Task? ParentTask { get; set; }
        public List<Task> SubTask { get; set; }
        public string SpentTime { get; set; }
        public string TimeSpan { get; set; }
        public Release Release { get; set; }
        public Project Project {  get; set; }
        public List<Commentary> Comments { get; set; }








    }
}
