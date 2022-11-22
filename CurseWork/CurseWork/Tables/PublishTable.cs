using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class PublishTable : Form, ITableDatabase
    {
        public PublishTable()
        {
            InitializeComponent();
            DbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            DbConnection.Open();
        }
        public OleDbConnection DbConnection { get; }
        private string[] columnNames = { "Код", "Видавництво", "Адрес", "Телефон" };
        private string[] types = { "int", "string", "string", "string" };
        private string[] values = new string[4];
        private void FillValues()
        {
            values[0] = CodeComboBox.Text;
            values[1] = PublishTextBox.Text;
            values[2] = AddressTextBox.Text;
            values[3] = PhoneTextBox.Text;
        }
        public void AddButton_Click(object sender, EventArgs e)
        {
            if (!FormService.IsValidData(CodeComboBox, PhoneTextBox, AddressTextBox, PublishTextBox))
            {
                MessageBox.Show("Усі поля повинні бути заповненими");
                return;
            }
            FillValues();
                string result = DatabaseHelper.CreateRecordSqlQuerry("Видавництво", DatabaseHelper.GetColumnValues(columnNames, types, values));
                DatabaseHelper.SaveToDataBaseWithoutResult(result, DbConnection);
                FormService.UpdateListViewWithDB(PublishListView, DbConnection, "SELECT * FROM Видавництво", 4);
        }

        public void RemoveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CodeComboBox.Text))
            {
                string result = DatabaseHelper.DeleteRecordSqlQuery("Видавництво", new ColumnValuePair("Код", "int", CodeComboBox.Text));
                DatabaseHelper.SaveToDataBaseWithoutResult(result, DbConnection);
                FormService.UpdateListViewWithDB(PublishListView, DbConnection, "SELECT * FROM Видавництво", 4);
            }
            else
            {
                MessageBox.Show("Код повинен бути заповненим!");
            }
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            if (!FormService.IsValidData(CodeComboBox, PhoneTextBox, AddressTextBox, PublishTextBox))
            {
                MessageBox.Show("Усі поля повинні бути заповненими");
                return;
            }
          
                FillValues();
                string result = DatabaseHelper.UpdateRecordSqlQuery("Видавництво", new ColumnValuePair("Код", "int", CodeComboBox.Text), DatabaseHelper.GetColumnValues(columnNames, types, values));
                DatabaseHelper.SaveToDataBaseWithoutResult(result, DbConnection);
                FormService.UpdateListViewWithDB(PublishListView, DbConnection, "SELECT * FROM Видавництво", 4);
            
        }

        public void TableForm_Load(object sender, EventArgs e)
        {
            PublishListView.FullRowSelect = true;
            FormService.UpdateListViewWithDB(PublishListView, DbConnection, "SELECT * FROM Видавництво", 4);
            FormService.LoadComboBoxFromDB(CodeComboBox, DbConnection, "SELECT Код FROM Видавництво");
        }

        public void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }

        public void TableListViewItem_Selected(object sender, EventArgs e)
        {
            try
            {
                var listView = PublishListView.SelectedItems[0];
                PublishTextBox.Text = listView.SubItems[1].Text;
                AddressTextBox.Text = listView.SubItems[2].Text;
                PhoneTextBox.Text = listView.SubItems[3].Text;
                FormService.SelectRowInComboBox(CodeComboBox, listView.SubItems[0].Text);
            }
            catch { }
        }
    }
}
