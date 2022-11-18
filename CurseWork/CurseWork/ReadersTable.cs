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
    public partial class ReadersTable : Form
    {
        private OleDbConnection _dbConnection;

        public ReadersTable()
        {
            InitializeComponent();
            _dbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            _dbConnection.Open();
        }


        private void LoaderForReaders()
        {
            ReadersListView.Items.Clear();
            OleDbCommand command;
            OleDbDataReader reader;
            command = new OleDbCommand("SELECT * FROM Читачі", _dbConnection);
            reader = command.ExecuteReader();
            ReadersListView.FullRowSelect = true;
            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader.GetString(0);
                for (int j = 1; j <= 3; j++)
                {
                    listViewItem.SubItems.Add(reader.GetValue(j).ToString());
                }

                ReadersListView.Items.Add(listViewItem);
            }

            reader.Close();
        }

        private void ReadersLoad(object sender, EventArgs e)
        {
            LoaderForReaders();
        }

        private void SelectedItem(object sender, EventArgs e)
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ForAddTextBox.Text))
            {
                Add();
                LoaderForReaders();
            }
            else
            {
                MessageBox.Show("Номер читацького квитка повинен бути заповненим!");
            }
        }
        public void Add()
        {
            OleDbCommand oleDbCommand = new OleDbCommand($"INSERT INTO Читачі (Номер_читацького_квитка, ПІБ_читача, Адреса_читача, Номер_телефона_читача) VALUES({ForAddTextBox.Text}, {FIOTextBox.Text}, {AdressTextBox.Text}, {PhoneTextBox.Text})", _dbConnection);
            oleDbCommand.ExecuteNonQuery();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                Delete();
                LoaderForReaders();
            }
            else
            {
                MessageBox.Show("Виберіть поле для видалення");
            }
        }
        public void Delete()
        {
            OleDbCommand command = new OleDbCommand($"DELETE FROM Читачі WHERE Номер_читацького_квитка='{NumberReaderComboBox.Text}'", _dbConnection);
            command.ExecuteNonQuery();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                Edit();
                LoaderForReaders();
            }
            else
            {
                MessageBox.Show("Виберіть поле для редагування!");
            }
        }
        public void Edit()
        {
            OleDbCommand oleDbCommand = new OleDbCommand($"UPDATE Читачі SET Номер_читацького_квитка =\'{NumberReaderComboBox.Text}\',  ПІБ_читача=\'{FIOTextBox.Text}\', Адреса_читача=\'{AdressTextBox.Text}\', Номер_телефона_читача=\'{PhoneTextBox.Text}\'  WHERE Номер_читацького_квитка=\'{NumberReaderComboBox.Text}\'", _dbConnection);
            oleDbCommand.ExecuteNonQuery();
        }
    }
}
