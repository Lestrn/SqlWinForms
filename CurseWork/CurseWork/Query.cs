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
        private string _selectQueryFromLibraryWithExpression = "SELECT * FROM Бібліотека WHERE Рік_видання > 2000";
        //private string _
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
                case "Выборка":
                    break;
                case "Проекция":
                    break;
                case "Соединение с выборкой":
                    break;
                case "Соединение с проекцией":
                    break;
                case "Агрегирующие функции SELECT":
                    break;
                case "Агрегирующие функции HAVING":
                    break;
                case "Группировка с условием":
                    break;
                case "Группировка без условия":
                    break;
                case "Объединение":
                    break;
                case "Пересечение":
                    break;
                case "Разность":
                    break;
                case "Деление":
                    break;
            }
        }

        private void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }
    }
}
