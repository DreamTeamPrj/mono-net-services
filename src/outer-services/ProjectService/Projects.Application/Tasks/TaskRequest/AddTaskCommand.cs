using MediatR;
using Projects.Core.Enums;

namespace Projects.Application.Tasks.TaskRequest
{
    public class AddTaskCommand : IRequest<long>
    {
        public int ProjectId { get; set; }
        /// <summary>
        /// заголовок таски
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// ссылка на документ с описанием таски
        /// </summary>
        public string DescriptionLink { get; set; }
        /// <summary>
        /// статус задачи
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// приоретет задачи 
        /// </summary>
        public Priority Priority { get; set; }
        /// <summary>
        /// список заказчиков которые просто набдюдают за выполнением задач
        /// </summary>
        public List<int> Inspectors { get; set; } = new List<int>();
        /// <summary>
        /// id того кто будет работать над таской
        /// </summary>
        public int? WorkerId { get; set; }
        /// <summary>
        /// ссылка на родительскую задачу (если она есть)
        /// </summary>
        public long? ParrentTaskId { get; set; }
        /// <summary>
        /// сроки разработки(выделеное время)
        /// </summary>
        public string? TimeSpan { get; set; }
        /// <summary>
        /// id релиза в котором разрабатывалась таска
        /// </summary>
        public int? ReleaseId { get; set; }
    }
}
