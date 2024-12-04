namespace Projects.Core.Entities
{
    public class Project
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public List<Task> TaskList { get; set; }
        public List<int> StatusList { get; set; }
        public List<int> RequiredStatus { get; set; }
        public List<Release> ReleaseList { get; set; }
        public List<int> Customers { get; set; }
        public Project ParrentProject { get; set; }
        public List<Project> SubProjects { get; set; }



    }
}
