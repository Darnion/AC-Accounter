using System;

namespace DataGridView_Adm_Com.Models
{
    /// <summary>
    /// Сущность пользователя
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Привилегии
        /// </summary>
        public string Privilege { get; set; }
    }
}
