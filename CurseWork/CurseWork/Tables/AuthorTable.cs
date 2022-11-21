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
    public partial class AuthorTable : Form, ITableDatabase
    {
        public AuthorTable()
        {
            InitializeComponent();
            DbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            DbConnection.Open();
        }

        public OleDbConnection DbConnection { get; }

        public void AddButton_Click(object sender, EventArgs e)
        {
            var sqlQuery = DatabaseHelper.CreateRecordSqlQuerry("Автори",
                new ColumnValuePair("Код_автора", "int", CodeAuthorTextBox.Text),
                new ColumnValuePair("ФІО", "string", PIBTextBox.Text),
                new ColumnValuePair("Примітки", "string", NoteTextBox.Text));
            DatabaseHelper.SaveToDataBaseWithoutResult(sqlQuery, DbConnection);
            FormService.UpdateListViewWithDB(AuthorListView, DbConnection, "SELECT * FROM Автори", 3);
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            var sqlQuery = DatabaseHelper.UpdateRecordSqlQuery("Автори", new ColumnValuePair("Код_автора", "int", CodeAuthorTextBox.Text),
                new ColumnValuePair("Код_автора", "int", CodeAuthorTextBox.Text),
                new ColumnValuePair("ФІО", "string", PIBTextBox.Text),
                new ColumnValuePair("Примітки", "string", NoteTextBox.Text));
            DatabaseHelper.SaveToDataBaseWithoutResult(sqlQuery, DbConnection);
            FormService.UpdateListViewWithDB(AuthorListView, DbConnection, "SELECT * FROM Автори", 3);
        }

        public void RemoveButton_Click(object sender, EventArgs e)
        {
            var sqlQuery = DatabaseHelper.DeleteRecordSqlQuery("Автори", new ColumnValuePair("Код_автора", "int", CodeAuthorTextBox.Text));
            DatabaseHelper.SaveToDataBaseWithoutResult(sqlQuery, DbConnection);
            FormService.UpdateListViewWithDB(AuthorListView, DbConnection, "SELECT * FROM Автори", 3);
        }

        public void TableForm_Load(object sender, EventArgs e)
        {
            AuthorListView.FullRowSelect = true;
            FormService.UpdateListViewWithDB(AuthorListView, DbConnection, "SELECT * FROM Автори", 3);
        }

        public void TableListViewItem_Selected(object sender, EventArgs e)
        {
            try
            {
                var listItem = AuthorListView.SelectedItems[0];
                CodeAuthorTextBox.Text = listItem.SubItems[0].Text;
                PIBTextBox.Text = listItem.SubItems[1].Text;
                NoteTextBox.Text = listItem.SubItems[2].Text;
            }
            catch { }
        }

        public void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }
    }
}