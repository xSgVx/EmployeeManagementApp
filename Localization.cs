using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp
{
    public class Localization
    {
        public static string Error = "Ошибка";
        public static string Saved = "Сохранено";
        public static string Message = "Сообщение";
        
        public static string ConfirmDelete(string FullName)
        {
            return ($"Удалить пользователя {FullName} навсегда?");
        }

    }
}
