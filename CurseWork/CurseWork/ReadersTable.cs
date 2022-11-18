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
                NumberReaderComboBox.Text = listView.SubItems[0].Text;
                FIOTextBox.Text = listView.SubItems[1].Text;
                AdressTextBox.Text = listView.SubItems[2].Text;
                PhoneTextBox.Text = listView.SubItems[3].Text;
            }
            catch { }
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ForAddTextBox.Text))
            {
                Add();
                FormService.UpdateListViewWithDB(ReadersListView, DbConnection, "SELECT * FROM Читачі", 4);
            }
            else
            {
                MessageBox.Show("Номер читацького квитка повинен бути заповненим!");
            }
        }
        public void Add()
        {
            OleDbCommand oleDbCommand = new OleDbCommand($"INSERT INTO Читачі (Номер_читацького_квитка, ПІБ_читача, Адреса_читача, Номер_телефона_читача) VALUES(\"{ForAddTextBox.Text}\", \"{FIOTextBox.Text}\", \"{AdressTextBox.Text}\", \"{PhoneTextBox.Text}\")", DbConnection);
            oleDbCommand.ExecuteNonQuery();
        }

        public void RemoveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                Delete();
                FormService.UpdateListViewWithDB(ReadersListView, DbConnection, "SELECT * FROM Читачі", 4);
            }
            else
            {
                MessageBox.Show("Виберіть поле для видалення");
            }
        }
        public void Delete()
        {
            OleDbCommand command = new OleDbCommand($"DELETE FROM Читачі WHERE Номер_читацького_квитка='{NumberReaderComboBox.Text}'", DbConnection);
            command.ExecuteNonQuery();
        }
        public void EditButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                Edit();
                FormService.UpdateListViewWithDB(ReadersListView, DbConnection, "SELECT * FROM Читачі", 4);
            }
            else
            {
                MessageBox.Show("Виберіть поле для редагування!");
            }
        }
        public void Edit()
        {
            OleDbCommand oleDbCommand = new OleDbCommand($"UPDATE Читачі SET Номер_читацького_квитка =\'{NumberReaderComboBox.Text}\',  ПІБ_читача=\'{FIOTextBox.Text}\', Адреса_читача=\'{AdressTextBox.Text}\', Номер_телефона_читача=\'{PhoneTextBox.Text}\'  WHERE Номер_читацького_квитка=\'{NumberReaderComboBox.Text}\'", DbConnection);
            oleDbCommand.ExecuteNonQuery();
        }

        public void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }
    }
}
