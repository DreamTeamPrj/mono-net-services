
using Projects.Core.Base;

namespace Projects.Core.Entities
{
    /// <summary>
    /// Релиз
    /// </summary>
    public class Release : BaseEntity<int>
    {
        /// <summary>
        /// Название релиза
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Дата конца
        /// </summary>
        public DateTime FinishDate { get; set; }

        /// <summary>
        /// Список задач релиза
        /// </summary>
        public ICollection<Task> TaskList { get; set; }

        /// <summary>
        /// Идентификатор проекта
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// Родительский проект
        /// </summary>
        public Project Project { get; set; }

    }
}