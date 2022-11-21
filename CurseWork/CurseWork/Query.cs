using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class Query : Form
    {
        private string selectorQuery = "SELECT * FROM Видавництво WHERE Код = 232";
        private string proectionQuery = "SELECT Бібліотека.Код_УДК, Бібліотека.Назва_книги FROM Бібліотека INNER JOIN Журнал ON Бібліотека.Код_УДК = Журнал.Код_УДК";
        private string connectionWithSelectorQuery = "SELECT Бібліотека.Назва_книги, Автори.ПІБ AS Автор_книги FROM Бібліотека INNER JOIN Автори ON Бібліотека.Код_автора_книги = Автори.Код_автора WHERE Автори.Код_автора = 44";
        private string connectionWithProectionQuery = "SELECT Бібліотека.Код_видавництва, Видавництво.Видавництво AS FROM Бібліотека INNER JOIN Видавництво ON Бібліотека.Код_видавництва = Видавництво.Код";
        private string groupingWithoutСonditionQuery = "SELECT Автори.ФІО AS Автор_книги, COUNT(Бібліотека.Назва_книги) AS Кількість_написаних_книг FROM Бібліотека INNER JOIN Автори ON Бібліотека.Код_автора_книги = Автори.Код_автора GROUP BY Автори.ПІБ";
        private string groupingWithСonditionQuery = "SELECT Жанри.Жанр, COUNT(Бібліотека.Назва_книги) AS Кількість_книг FROM Бібліотека INNER JOIN Жанри ON Бібліотека.Код_жанру = Жанри.Код_жанра WHERE  Жанр = ‘роман’ GROUP BY Бібліотека.Назва_книги";
        private string agregationSelectHavingQuery = "SELECT AVG(Ціна) AS Середня_ціна FROM Бібліотека";
        private string agregationSelectHavingQuery2 = "SELECT Назва_книги, MIN(Рік_видання) AS  Рік_видання FROM Бібліотека GROUP BY Назва_книги HAVING MIN(Рік_видання)< 2000";
        private string crossQuery = "SELECT Номер_читацького_квитка FROM Журнал INTERSECT SELECT Номер_читацького_квитка, ПІБ_читача, Номер_телефона_читача FROM Читачі";
        private string uniteQuery = "SELECT ПІБ_читача FROM Читачі UNION SELECT Адреса_читача FROM Читачі";
        private string substructionQuery = "SELECT * FROM Читачі EXCEPT SELECT Номер_читацького_квитка FROM Журнал";
        private string divisionQuery = "SELECT * FROM Журнал WHERE Статус = ‘заброньована’ AND Статус = ‘взята на прочитання’ GROUP BY Номер_читацького_квитка";
        public Query(string selectedQuery)
        {
            InitializeComponent();
            Text = selectedQuery;
            DbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            DbConnection.Open();
        }

        public OleDbConnection DbConnection { get; }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Вибірка":
                    break;
                case "Проекція":
                    break;
                case "З'єднання з вибіркою":
                    break;
                case "З'єднання з проекцією":
                    break;
                case "Агрегуючі функції SELECT":
                    break;
                case "Агрегуючі функції HAVING":
                    break;
                case "Угруповання з умовою":
                    break;
                case "Угруповання без умови":
                    break;
                case "Об'єднання":
                    break;
                case "Перетин":
                    break;
                case "Різниця":
                    break;
                case "Поділ":
                    break;
            }
        }

        private void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }
    }
}
