using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementApp
{
    /// <summary>
    /// Интерфейс для реализации методов связанных с выбором таблицы
    /// </summary>
    public interface UISource
    {
        /// <summary>
        /// Обновление таблицы
        /// </summary>
        void RebuildDataSource();
        /// <summary>
        /// Метод для поиска в нужной таблице
        /// </summary>
        /// <param name="searchKey"></param>
        void RebuildListFilter(string searchKey);

    }

    class EmployeeUISource : UISource
    {
        EmployeeEntities db;
        BindingSource bindingSource;

        public EmployeeUISource(EmployeeEntities db, BindingSource bindingSource)
        {
            this.db = db;
            this.bindingSource = bindingSource;
        }

        void UISource.RebuildDataSource()
        {
            bindingSource.DataSource = db.Employee.ToList();
        }

        void UISource.RebuildListFilter(string searchKey)
        {
            var query = from match in db.Employee.Where(x => x.Id.ToString().Contains(searchKey) ||
                                                 x.ФИО.Contains(searchKey) ||
                                                 x.Департамент.Contains(searchKey) ||
                                                 x.Должность.Contains(searchKey) ||
                                                 x.Категория.Contains(searchKey)).Where(x => x.Уволен.Equals(false))
                        select match;

            bindingSource.DataSource = query.ToList();
        }
    }
}
