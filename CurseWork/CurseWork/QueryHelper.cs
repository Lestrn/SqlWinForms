using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Выборка
//Проекция
//Соединение с выборкой
//Соединение с проекцией
//Агрегирующие функции SELECT
//Агрегирующие функции HAVING
//Группировка с условием
//Группировка без условия
//Объединение
//Пересечение
//Разность
//Деление
namespace CurseWork
{
    public static class QueryHelper
    {
        public static string Selector(string table)
        {
            return $"SELECT * FROM {table}";
        }
        public static string Proection(string table)
        {
            return $"SELECT (column name) FROM {table} WHERE (Your choice)";
        }
        public static string SelectorWithJoin(string table)
        {
            return $"SELECT * FROM {table} JOIN (table2) ON (условие)";
        }
    }
}
