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
    public partial class GenresTable : Form, ITableDatabase
    {
        public GenresTable()
        {
            InitializeComponent();
            DbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            DbConnection.Open();
        }

        public OleDbConnection DbConnection { get; }

        public void AddButton_Click(object sender, EventArgs e)
        {
            var sqlQuery = DatabaseHelper.CreateRecordSqlQuerry("Жанри",
                new ColumnValue("Код_жанра", "int", CodeGenreTextBox.Text),
                new ColumnValue("Жанр", "string", GenreTextBox.Text));
            DatabaseHelper.SaveToDataBaseWithoutResult(sqlQuery, DbConnection);
            FormService.UpdateListViewWithDB(GenresListView, DbConnection, "SELECT * FROM Жанри", 2);
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            var sqlQuery = DatabaseHelper.UpdateRecordSqlQuery("Жанри", new ColumnValue("Код_жанра", "int", CodeGenreTextBox.Text),
                new ColumnValue("Код_жанра", "int", CodeGenreTextBox.Text),
                new ColumnValue("Жанр", "string", GenreTextBox.Text));
            DatabaseHelper.SaveToDataBaseWithoutResult(sqlQuery, DbConnection);
            FormService.UpdateListViewWithDB(GenresListView, DbConnection, "SELECT * FROM Жанри", 2);
        }

        public void RemoveButton_Click(object sender, EventArgs e)
        {
            var sqlQuery = DatabaseHelper.DeleteRecordSqlQuery("Жанри", new ColumnValue("Код_жанра", "int", CodeGenreTextBox.Text));
            DatabaseHelper.SaveToDataBaseWithoutResult(sqlQuery, DbConnection);
            FormService.UpdateListViewWithDB(GenresListView, DbConnection, "SELECT * FROM Жанри", 2);
        }

        public void TableForm_Load(object sender, EventArgs e)
        {
            GenresListView.FullRowSelect = true;
            FormService.UpdateListViewWithDB(GenresListView, DbConnection, "SELECT * FROM Жанри", 2);
        }

        public void TableListViewItem_Selected(object sender, EventArgs e)
        {
            try
            {
                var listItem = GenresListView.SelectedItems[0];
                CodeGenreTextBox.Text = listItem.SubItems[0].Text;
                GenreTextBox.Text = listItem.SubItems[1].Text;
            }
            catch { }
        }

        public void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }
    }
}
