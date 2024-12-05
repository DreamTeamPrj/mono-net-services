using Projects.Core.Base;

namespace Projects.Core.Entities
{
    /// <summary>
    /// Проект
    /// </summary>
    public class Project : BaseEntity<int>
    {
        /// <summary>
        /// Название проекта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тэг проекта
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Список задач в проекте
        /// </summary>
        public ICollection<Task> TaskList { get; set; }

        /// <summary>
        /// Список статусов
        /// </summary>
        public List<int> StatusList { get; set; }

        /// <summary>
        /// Обязательные статусы
        /// </summary>
        public List<int> RequiredStatuses { get; set; }

        /// <summary>
        /// Списиок релизов
        /// </summary>
        public ICollection<Release> ReleaseList { get; set; }

        /// <summary>
        /// Список создателей/заказчиков
        /// </summary>
        public List<int> CustomersId { get; set; }

        /// <summary>
        /// Идентификатор родительского проекта
        /// </summary>
        public int ParentProjectId { get; set; }

        /// <summary>
        /// Родительский проект
        /// </summary>
        public Project ParentProject { get; set; }

        /// <summary>
        /// Подпроекты
        /// </summary>
        public ICollection<Project> SubProjects { get; set; }
    }
}
