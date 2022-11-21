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
        private string connectionWithSelectorQuery = "SELECT Бібліотека.Назва_книги, Автори.ФІО AS Автор_книги FROM Бібліотека INNER JOIN Автори ON Бібліотека.Код_автора_книги = Автори.Код_автора WHERE Автори.Код_автора = 44";
        private string connectionWithProectionQuery = "SELECT Бібліотека.Код_видавництва, Видавництво.Видавництво FROM Бібліотека INNER JOIN Видавництво ON Бібліотека.Код_видавництва = Видавництво.Код";
        private string groupingWithoutСonditionQuery = "SELECT Автори.ФІО AS Автор_книги, COUNT(Бібліотека.Назва_книги) AS Кількість_написаних_книг FROM Бібліотека INNER JOIN Автори ON Бібліотека.Код_автора_книги = Автори.Код_автора GROUP BY Автори.ФІО";
        private string groupingWithСonditionQuery = "SELECT Бібліотека.Назва_книги, COUNT(Жанри.Жанр) AS Кількість_книг FROM Бібліотека INNER JOIN Жанри ON Бібліотека.Код_жанру=Жанри.Код_жанра WHERE  Жанр=\"роман\" GROUP BY Бібліотека.Назва_книги";
        private string agregationSelectQuery = "SELECT AVG(Ціна) AS Середня_ціна FROM Бібліотека";
        private string agregationHavingQuery = "SELECT Назва_книги, MIN(Рік_видання) AS  Рік_видання FROM Бібліотека GROUP BY Назва_книги HAVING MIN(Рік_видання)< 2000";
        private string crossQuery = "SELECT Номер_читацького_квитка FROM Журнал INTERSECT SELECT Номер_читацького_квитка, ПІБ_читача, Номер_телефона_читача FROM Читачі";
        private string uniteQuery = "SELECT ПІБ_читача FROM Читачі UNION SELECT Адреса_читача FROM Читачі";
        private string substructionQuery = "SELECT * FROM Читачі EXCEPT SELECT Номер_читацького_квитка FROM Журнал";
        private string divisionQuery = "SELECT Номер_читацького_квитка FROM Журнал WHERE Статус = ‘заброньована’ AND Статус = ‘взята на прочитання’ GROUP BY Номер_читацького_квитка";
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
                    
                    FormService.RebuildListView(QueryListView, "Код", "Видавництво", "Адрес", "Телефон"); //+
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, selectorQuery, 4);
                    break;
                case "Проекція":
                    FormService.RebuildListView(QueryListView, "Код УДК", "Назва книги");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection,  proectionQuery, 2); //+
                    break;
                case "З'єднання з вибіркою":
                    FormService.RebuildListView(QueryListView, "Назва книги", "Автор книги");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, connectionWithSelectorQuery, 2); //+
                    break;
                case "З'єднання з проекцією":
                    FormService.RebuildListView(QueryListView, "Код видавництва", "Видавництво"); //+
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, connectionWithProectionQuery, 2);
                    break;
                case "Агрегуючі функції SELECT":
                    FormService.RebuildListView(QueryListView, "Середня ціна"); //+
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, agregationSelectQuery, 1);
                    break;
                case "Агрегуючі функції HAVING":
                    FormService.RebuildListView(QueryListView, "Назва книги", "Рік видання"); //+
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, agregationHavingQuery, 2);
                    break;
                case "Угруповання з умовою":
                    FormService.RebuildListView(QueryListView, "Жанр", "Кількість книг"); //+
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, groupingWithСonditionQuery, 2);
                    break;
                case "Угруповання без умови":
                    FormService.RebuildListView(QueryListView, "Автор книги", "Кількість  напианих книг"); //+
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, groupingWithoutСonditionQuery, 2);
                    break;
                case "Об'єднання":
                    FormService.RebuildListView(QueryListView, "ПІБ_Адреса"); //+
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, uniteQuery, 1);
                    break;
                case "Перетин":
                    FormService.RebuildListView(QueryListView,  "Номер читацького квитка"); //+
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, crossQuery, 1);
                    break;
                case "Різниця":
                    FormService.RebuildListView(QueryListView, "Номер читацького квитка", "ПІБ", "Адреса", "Телефон");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, substructionQuery, 4);
                    break;
                case "Поділ":
                    FormService.RebuildListView(QueryListView, "Код УДК", "Статус", "Номер читацького квитка");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, divisionQuery, 3);
                    break;
            }
        }
      
        private void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
