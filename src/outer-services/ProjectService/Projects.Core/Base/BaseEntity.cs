namespace Projects.Core.Base
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    /// <typeparam name="TId">Тип идентифекатора</typeparam>
    public class BaseEntity<TId>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public TId Id { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}
