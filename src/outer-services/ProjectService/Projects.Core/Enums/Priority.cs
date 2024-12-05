using System.ComponentModel;

namespace Projects.Core.Enums
{
    /// <summary>
    /// Приоритет задачи
    /// </summary>
    public enum Priority
    {
        /// <summary>
        /// Низкий
        /// </summary>
        [Description("Низкий")]
        Low,

        /// <summary>
        /// Нормальный
        /// </summary>
        [Description("Нормальный")]
        Medium,

        /// <summary>
        /// Высокий
        /// </summary>
        [Description("Высокий")]
        High
    }
}
