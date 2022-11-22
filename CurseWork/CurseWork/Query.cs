using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class Query : Form
    {
        private string _selectorQuery = "SELECT * FROM Видавництво WHERE Код = 232";
        private string _descriptionSelectorQuery = "Інформація про видавництво із кодом 232 із таблиці Видавництво";

        private string _proectionQuery = "SELECT Бібліотека.Код_УДК, Бібліотека.Назва_книги FROM Бібліотека INNER JOIN Журнал ON Бібліотека.Код_УДК = Журнал.Код_УДК";
        private string _descriptionProectionQuery = "Код УДК та назва книг, які були записані до Журналу";

        private string _connectionWithSelectorQuery = "SELECT Бібліотека.Назва_книги, Автори.ФІО AS Автор_книги FROM Бібліотека INNER JOIN Автори ON Бібліотека.Код_автора_книги = Автори.Код_автора WHERE Автори.Код_автора = 44";
        private string _descriptionСonnectionWithSelectorQuery = "Усі книги, які написав автор із кодом 44 – Достоєвський";

        private string _connectionWithProectionQuery = "SELECT Бібліотека.Код_видавництва, Видавництво.Видавництво FROM Бібліотека INNER JOIN Видавництво ON Бібліотека.Код_видавництва = Видавництво.Код";
        private string _descriptionСonnectionWithProectionQuery = "Код видавництва та його назва";

        private string _groupingWithoutСonditionQuery = "SELECT Автори.ФІО AS Автор_книги, COUNT(Бібліотека.Назва_книги) AS Кількість_написаних_книг FROM Бібліотека INNER JOIN Автори ON Бібліотека.Код_автора_книги = Автори.Код_автора GROUP BY Автори.ФІО";
        private string _descriptionGroupingWithoutСonditionQuery = "Кількість книг, написані кожним автором";

        private string _groupingWithСonditionQuery = "SELECT Бібліотека.Назва_книги, COUNT(Жанри.Жанр) AS Кількість_книг FROM Бібліотека INNER JOIN Жанри ON Бібліотека.Код_жанру=Жанри.Код_жанра WHERE  Жанр=\"роман\" GROUP BY Бібліотека.Назва_книги";
        private string _descriptionGroupingWithСonditionQuery = "Кількість книг із жанром роман";

        private string _agregationSelectQuery = "SELECT AVG(Ціна) AS Середня_ціна FROM Бібліотека";
        private string _descriptionAgregationSelectQuery = "Середня ціна за всі книги у Бібліотеці";

        private string _agregationHavingQuery = "SELECT Назва_книги, MIN(Рік_видання) AS  Рік_видання FROM Бібліотека GROUP BY Назва_книги HAVING MIN(Рік_видання)< 2000";
        private string _descriptionAgregationHavingQuery = "Найменування книг, які були видані ще до 2000 року";

        private string _crossQuery = "SELECT * FROM Читачі WHERE EXISTS (SELECT Номер_читацького_квитка FROM Журнал WHERE Номер_читацького_квитка = Читачі.Номер_читацького_квитка)";
        private string _descriptionCrossQuery = "Інформацію про читачів, які були записані до Журналу";

        private string _uniteQuery = "SELECT ПІБ_читача FROM Читачі UNION SELECT Адреса_читача FROM Читачі";
        private string _descriptionUniteQuery = "ПІБ читача та його адреса з використанням оператора UNION";

        private string _substructionQuery = "SELECT * FROM Читачі WHERE NOT EXISTS (SELECT Номер_читацького_квитка FROM Журнал WHERE Номер_читацького_квитка = Читачі.Номер_читацького_квитка)";
        private string _descriptionSubstructionQuery = "Інформація про читачів, які не були записані до Журналу";

        private string _divisionQuery = "SELECT Номер_читацького_квитка, ПІБ_читача FROM Читачі WHERE Номер_читацького_квитка IN(SELECT Номер_читацького_квитка FROM Журнал WHERE Статус = 'взята на прочитання') AND Номер_читацького_квитка IN (SELECT Номер_читацького_квитка FROM Журнал WHERE  Статус = 'заброньована')";
        private string _descriptionDivisionQuery = "Читачі, які взяли книгу на прочитання та забронювали іншу";

        public Query(string selectedQuery)
        {
            InitializeComponent();
            Text = selectedQuery;
            DbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            DbConnection.Open();
        }

        public OleDbConnection DbConnection { get; }

        private void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Вибірка":
                    QueryTextBox.Text = _selectorQuery;
                    CaptionLabel.Text = _descriptionSelectorQuery;
                    FormService.RebuildListView(QueryListView, "Код", "Видавництво", "Адрес", "Телефон");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _selectorQuery, 4);
                    break;
                case "Проекція":
                    QueryTextBox.Text = _proectionQuery;
                    CaptionLabel.Text = _descriptionProectionQuery;
                    FormService.RebuildListView(QueryListView, "Код УДК", "Назва книги");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _proectionQuery, 2);
                    break;
                case "З'єднання з вибіркою":
                    QueryTextBox.Text = _connectionWithSelectorQuery;
                    CaptionLabel.Text = _descriptionСonnectionWithSelectorQuery;
                    FormService.RebuildListView(QueryListView, "Назва книги", "Автор книги");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _connectionWithSelectorQuery, 2);
                    break;
                case "З'єднання з проекцією":
                    QueryTextBox.Text = _connectionWithProectionQuery;
                    CaptionLabel.Text = _descriptionСonnectionWithProectionQuery;
                    FormService.RebuildListView(QueryListView, "Код видавництва", "Видавництво");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _connectionWithProectionQuery, 2);
                    break;
                case "Агрегуючі функції SELECT":
                    QueryTextBox.Text = _agregationSelectQuery;
                    CaptionLabel.Text = _descriptionAgregationSelectQuery;
                    FormService.RebuildListView(QueryListView, "Середня ціна");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _agregationSelectQuery, 1);
                    break;
                case "Агрегуючі функції HAVING":
                    QueryTextBox.Text = _agregationHavingQuery;
                    CaptionLabel.Text = _descriptionAgregationHavingQuery;
                    FormService.RebuildListView(QueryListView, "Назва книги", "Рік видання");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _agregationHavingQuery, 2);
                    break;
                case "Угруповання з умовою":
                    QueryTextBox.Text = _groupingWithСonditionQuery;
                    CaptionLabel.Text = _descriptionGroupingWithСonditionQuery;
                    FormService.RebuildListView(QueryListView, "Жанр", "Кількість книг");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _groupingWithСonditionQuery, 2);
                    break;
                case "Угруповання без умови":
                    QueryTextBox.Text = _groupingWithoutСonditionQuery;
                    CaptionLabel.Text = _descriptionGroupingWithoutСonditionQuery;
                    FormService.RebuildListView(QueryListView, "Автор книги", "Кількість  напианих книг");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _groupingWithoutСonditionQuery, 2);
                    break;
                case "Об'єднання":
                    QueryTextBox.Text = _uniteQuery;
                    CaptionLabel.Text = _descriptionUniteQuery;
                    FormService.RebuildListView(QueryListView, "ПІБ читача та Адреса");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _uniteQuery, 1);
                    break;
                case "Перетин":
                    QueryTextBox.Text = _crossQuery;
                    CaptionLabel.Text = _descriptionCrossQuery;
                    FormService.RebuildListView(QueryListView, "Номер читацького квитка", "ПІБ читача", "Адреса", "Телефон");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _crossQuery, 4);
                    break;
                case "Різниця":
                    QueryTextBox.Text = _substructionQuery;
                    CaptionLabel.Text = _descriptionSubstructionQuery;
                    FormService.RebuildListView(QueryListView, "Номер читацького квитка", "ПІБ", "Адреса", "Телефон");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _substructionQuery, 4);
                    break;
                case "Поділ":
                    QueryTextBox.Text = _divisionQuery;
                    CaptionLabel.Text = _descriptionDivisionQuery;
                    FormService.RebuildListView(QueryListView, "Номер читацького квитка", "ПІБ читача");
                    FormService.UpdateListViewWithDB(QueryListView, DbConnection, _divisionQuery, 2);
                    break;
            }
        }
    }
}
