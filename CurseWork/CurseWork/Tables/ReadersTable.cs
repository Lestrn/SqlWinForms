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
    public partial class ReadersTable : Form, ITableDatabase
    {
        public OleDbConnection DbConnection { get; }

        public ReadersTable()
        {
            InitializeComponent();
            DbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            DbConnection.Open();
        }
        public void TableForm_Load(object sender, EventArgs e)
        {
            ReadersListView.FullRowSelect = true;
            FormService.UpdateListViewWithDB(ReadersListView, DbConnection, "SELECT * FROM Читачі", 4);
            FormService.LoadComboBoxFromDB(NumberReaderComboBox, DbConnection, "SELECT Номер_читацького_квитка FROM Читачі");
        }

        public void TableListViewItem_Selected(object sender, EventArgs e)
        {
            try
            {
                var listView = ReadersListView.SelectedItems[0];
                FIOTextBox.Text = listView.SubItems[1].Text;
                AdressTextBox.Text = listView.SubItems[2].Text;
                PhoneTextBox.Text = listView.SubItems[3].Text;
                FormService.SelectRowInComboBox(NumberReaderComboBox, listView.SubItems[0].Text);
            }
            catch { }

        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ForAddTextBox.Text))
            {
                string result = DatabaseHelper.CreateRecordSqlQuerry("Читачі",
                    new ColumnValuePair("Номер_читацького_квитка", "string", ForAddTextBox.Text),
                    new ColumnValuePair("ПІБ_читача", "string", FIOTextBox.Text),
                    new ColumnValuePair("Адреса_читача", "string", AdressTextBox.Text),
                    new ColumnValuePair("Номер_телефона_читача", "string", PhoneTextBox.Text));
                DatabaseHelper.SaveToDataBaseWithoutResult(result, DbConnection);
                FormService.UpdateListViewWithDB(ReadersListView, DbConnection, "SELECT * FROM Читачі", 4);
            }
            else
            {
                MessageBox.Show("Номер читацького квитка повинен бути заповненим!");
            }
        }

        public void RemoveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                string result = DatabaseHelper.DeleteRecordSqlQuery("Читачі", new ColumnValuePair("Номер_читацького_квитка", "string", NumberReaderComboBox.Text));
                DatabaseHelper.SaveToDataBaseWithoutResult(result, DbConnection);
                FormService.UpdateListViewWithDB(ReadersListView, DbConnection, "SELECT * FROM Читачі", 4);
            }
            else
            {
                MessageBox.Show("Виберіть поле для видалення");
            }
        }
        public void EditButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                string result = DatabaseHelper.UpdateRecordSqlQuery("Читачі", new ColumnValuePair("Номер_читацького_квитка", "string", NumberReaderComboBox.Text),
                    new ColumnValuePair("Номер_читацького_квитка", "string", NumberReaderComboBox.Text),
                    new ColumnValuePair("ПІБ_читача", "string", FIOTextBox.Text),
                    new ColumnValuePair("Адреса_читача", "string", AdressTextBox.Text),
                    new ColumnValuePair("Номер_телефона_читача", "string", PhoneTextBox.Text));
                DatabaseHelper.SaveToDataBaseWithoutResult(result, DbConnection);
                FormService.UpdateListViewWithDB(ReadersListView, DbConnection, "SELECT * FROM Читачі", 4);
            }
            else
            {
                MessageBox.Show("Виберіть поле для редагування!");
            }
        }

        public void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }
    }
}
