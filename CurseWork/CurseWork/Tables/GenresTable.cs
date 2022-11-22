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
            if (!FormService.IsValidData(CodeGenreTextBox, GenreTextBox))
            {
                MessageBox.Show("Заповніть дані", "Error", MessageBoxButtons.OK);
                return;
            }

            var sqlQuery = DatabaseHelper.CreateRecordSqlQuerry("Жанри",
                new ColumnValuePair("Код_жанра", "int", CodeGenreTextBox.Text),
                new ColumnValuePair("Жанр", "string", GenreTextBox.Text));
            DatabaseHelper.SaveToDataBaseWithoutResult(sqlQuery, DbConnection);
            FormService.UpdateListViewWithDB(GenresListView, DbConnection, "SELECT * FROM Жанри", 2);
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            if (GenresListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть рядок з списку для редагування", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!FormService.IsValidData(CodeGenreTextBox, GenreTextBox))
            {
                MessageBox.Show("Заповніть дані", "Error", MessageBoxButtons.OK);
                return;
            }

            var sqlQuery = DatabaseHelper.UpdateRecordSqlQuery("Жанри", new ColumnValuePair("Код_жанра", "int", CodeGenreTextBox.Text),
                new ColumnValuePair("Код_жанра", "int", CodeGenreTextBox.Text),
                new ColumnValuePair("Жанр", "string", GenreTextBox.Text));
            DatabaseHelper.SaveToDataBaseWithoutResult(sqlQuery, DbConnection);
            FormService.UpdateListViewWithDB(GenresListView, DbConnection, "SELECT * FROM Жанри", 2);
        }

        public void RemoveButton_Click(object sender, EventArgs e)
        {
            if (GenresListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть рядок з списку для видалення", "Error", MessageBoxButtons.OK);
                return;
            }

            var sqlQuery = DatabaseHelper.DeleteRecordSqlQuery("Жанри", new ColumnValuePair("Код_жанра", "int", CodeGenreTextBox.Text));
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
