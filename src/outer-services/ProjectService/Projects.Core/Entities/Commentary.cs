using Projects.Core.Base;

namespace Projects.Core.Entities
{
    /// <summary>
    /// Комментарий
    /// </summary>
    public class Commentary : BaseEntity<int>
    {
        /// <summary>
        /// Контент комментария
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Идентификатор автора
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Идентификатор родительского комментария
        /// </summary>
        public int? ParentId { get; set; }
        
        /// <summary>
        /// Родительский комментарий
        /// </summary>
        public Commentary? ParentCommentary { get; set; }

        /// <summary>
        /// Подкомментарии
        /// </summary>
        public List<Commentary> SubComments { get; set; }

        /// <summary>
        /// Идентификатор заявки
        /// </summary>
        public long TaskId { get; set; }

        /// <summary>
        /// Заявка
        /// </summary>
        public Task Task { get; set; }
    }
}