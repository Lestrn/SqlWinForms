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
    public partial class MagazineTable : Form
    {
        private OleDbConnection _dbConnection;
        public MagazineTable()
        {
            InitializeComponent();
            _dbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            _dbConnection.Open();
        }

        private void LoaderForMagazine()
        {
            MagazineListView.Items.Clear();
            OleDbCommand command;
            OleDbDataReader reader;
            command = new OleDbCommand("SELECT * FROM Журнал", _dbConnection);
            reader = command.ExecuteReader();
            MagazineListView.FullRowSelect = true;
            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader.GetString(0);
                for (int j = 1; j <= 2; j++)
                {
                    listViewItem.SubItems.Add(reader.GetValue(j).ToString());
                }

                MagazineListView.Items.Add(listViewItem);
            }

            reader.Close();
        }

        private void MagazineLoad(object sender, EventArgs e)
        {
            LoaderForMagazine();
        }

        private void SelectedItem(object sender, EventArgs e)
        {
            try
            {
                var listView = MagazineListView.SelectedItems[0];
                CodeNumberTextBox.Text = listView.SubItems[0].Text;
                StatusTextBox.Text = listView.SubItems[1].Text;
                NumberReaderComboBox.Text = listView.SubItems[2].Text;
            }
            catch { }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AddNumberReaderTextBox.Text))
            {
                Add();
                LoaderForMagazine();
            }
            else
            {
                MessageBox.Show("Номер читацького квитка повинен бути заповненим!");
            }
        }
        private void Add()
        {
            OleDbCommand oleDbCommand = new OleDbCommand($"INSERT INTO Журнал (Код_УДК, Статус, Номер_читацького_квитка) VALUES({CodeNumberTextBox.Text}, {StatusTextBox.Text}, {AddNumberReaderTextBox.Text}");
            oleDbCommand.ExecuteNonQuery();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                Edit();
                LoaderForMagazine();
            }
            else
            {
                MessageBox.Show("Виберіть поле для редагування!");
            }
        }
        private void Edit()
        {
            OleDbCommand oleDbCommand = new OleDbCommand($"UPDATE Журнал SET  Код_УДК=\'{CodeNumberTextBox.Text}\',  Статус=\'{StatusTextBox.Text}\' Номер_читацького_квитка=\'{NumberReaderComboBox.Text}\'  WHERE Номер_читацького_квитка=\'{NumberReaderComboBox.Text}\'", _dbConnection);
            oleDbCommand.ExecuteNonQuery();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                Delete();
                LoaderForMagazine();
            }
            else
            {
                MessageBox.Show("Виберіть поле для видалення!");
            }
        }
        private void Delete()
        {
            OleDbCommand command = new OleDbCommand($"DELETE FROM Журнал WHERE Номер_читацького_квитка='{NumberReaderComboBox.Text}'", _dbConnection);
            command.ExecuteNonQuery();
        }
    }
}
