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
        private bool _isSelected = false;
        private ListView.SelectedListViewItemCollection _currentSelected;
        
        public ReadersTable()
        {
            InitializeComponent();
            _dbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            _dbConnection.Open();
        }


        private void LoaderForReaders()
        {
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
           
            _currentSelected = ReadersListView.SelectedItems;
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
            }
            else
            {
                MessageBox.Show("Номер читацького квитка повинен бути заповненим!");
            }
        }
        public void Add()
        {
            OleDbCommand oleDbCommand = new OleDbCommand($"INSERT INTO Читачі (Номер читацького квитка, ПІБ читача, Адреса читача, Номер телефона читача) VALUES({ForAddTextBox.Text}, {FIOTextBox.Text}, {AdressTextBox.Text}, {PhoneTextBox.Text})", _dbConnection);
            oleDbCommand.ExecuteNonQuery();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                Delete();
            }
            else
            {
                MessageBox.Show("Виберіть поле для видалення");
            }
        }
        public void Delete()
        {
            OleDbCommand command = new OleDbCommand($"DELETE FROM Бібліотека WHERE Назва='{NumberReaderComboBox.Text}'", _dbConnection);
            command.ExecuteNonQuery();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                Edit();
            }
            else
            {
                MessageBox.Show("Виберіть поле для редагування!");
            }
        }
        public void Edit()
        {
            OleDbCommand oleDbCommand = new OleDbCommand($"UPDATE Читачі SET Номер читацького квитка =\'{NumberReaderComboBox.Text}\',  ПІБ читача=\'{FIOTextBox.Text}\', Адреса читача=\'{AdressTextBox.Text}\', Номер телефона читача=\'{PhoneTextBox.Text}\'  WHERE Номер читацького квитка=\'{NumberReaderComboBox.Text}\'", _dbConnection);
            oleDbCommand.ExecuteNonQuery();
        }
    }
}
