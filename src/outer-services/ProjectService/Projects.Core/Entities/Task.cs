using Projects.Core.Base;
using Projects.Core.Enums;

namespace Projects.Core.Entities
{
    /// <summary>
    /// Задача, заявка
    /// </summary>
    public class Task : BaseEntity<long>
    {
        /// <summary>
        /// Составной номер задачи
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Заголовок задачи
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Ссылка на HTML документ описания
        /// </summary>
        public string DescriptionLink { get; set; }

        /// <summary>
        /// Идентификатор статуса(Dictionary)
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// Приоритет задачи
        /// </summary>
        public Priority Priority { get; set; }

        /// <summary>
        /// Идентификатор заявителя
        /// </summary>
        public int CreatorId {  get; set; }

        /// <summary>
        /// Идентификатор исполнителя
        /// </summary>
        public int? WorkerId { get; set; }

        /// <summary>
        /// Список наблюдателей
        /// </summary>
        public List<int> InspectorsId { get; set; }

        /// <summary>
        /// Идентификатор проекта
        /// </summary>
        public long? ParentTaskId { get; set; }

        /// <summary>
        /// Родительская задача
        /// </summary>
        public Task? ParentTask { get; set; }

        /// <summary>
        /// Список подзадач
        /// </summary>
        public ICollection<Task> SubTaskList { get; set; }

        /// <summary>
        /// Потраченное время
        /// </summary>
        public string SpentTime { get; set; }

        /// <summary>
        /// Планируемое время
        /// </summary>
        public string TimeSpan { get; set; }

        /// <summary>
        /// Идентификатор релиза
        /// </summary>
        public int? ReleaseId { get; set; }

        /// <summary>
        /// Релиз
        /// </summary>
        public Release? Release { get; set; }

        /// <summary>
        /// Идентификатор проекта
        /// </summary>
        public int ProjectId { get; set; }

        /// <summary>
        /// Проект
        /// </summary>
        public Project Project {  get; set; }
        
        /// <summary>
        /// Комментарии
        /// </summary>
        public ICollection<Commentary> Comments { get; set; }
    }
}