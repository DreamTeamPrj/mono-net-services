namespace Projects.Core.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public List<Task> TaskList { get; set; }
        public List<int> StatusList { get; set; }
        public List<int> RequiredStatuses { get; set; }
        public List<Release> ReleaseList { get; set; }
        public List<int> Customers { get; set; }
        public Project ParentProject { get; set; }
        public List<Project> SubProjects { get; set; }



    }
}
