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
    public partial class MagazineTable : Form, ITableDatabase
    {
       
        public MagazineTable()
        {
            InitializeComponent();
            DbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            DbConnection.Open();
        }
        public OleDbConnection DbConnection { get; }
        private string[] columnNames = { "Код_УДК", "Статус", "Номер_читацького_квитка" };
        private string[] types = {"string", "string", "string" };
        private string[] values = new string[3];
 
        public void TableForm_Load(object sender, EventArgs e)
        {
            MagazineListView.FullRowSelect = true;
            FormService.UpdateListViewWithDB(MagazineListView, DbConnection, "SELECT * FROM Журнал", 3);
            FormService.LoadComboBoxFromDB(NumberReaderComboBox, DbConnection, "SELECT Номер_читацького_квитка FROM Читачі");
        }

        public void TableListViewItem_Selected(object sender, EventArgs e)
        {
            try
            {
                var listView = MagazineListView.SelectedItems[0];
                CodeNumberTextBox.Text = listView.SubItems[0].Text;
                StatusTextBox.Text = listView.SubItems[1].Text;
                FormService.SelectRowInComboBox(NumberReaderComboBox, listView.SubItems[2].Text);
            }
            catch { }
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            if (!FormService.IsValidData(CodeNumberTextBox, StatusTextBox, NumberReaderComboBox))
            {
                MessageBox.Show("Усі поля повинні бути заповненими");
                return;
            }
    
                FillValuesArr();
                ColumnValuePair[] columnValues = DatabaseHelper.GetColumnValues(columnNames, types, values);
                string result = DatabaseHelper.CreateRecordSqlQuerry("Журнал", columnValues);
                DatabaseHelper.SaveToDataBaseWithoutResult(result, DbConnection);
                FormService.UpdateListViewWithDB(MagazineListView, DbConnection, "SELECT * FROM Журнал", 3);
            
        }
        private void FillValuesArr()
        {
            values[0] = CodeNumberTextBox.Text;
            values[1] = StatusTextBox.Text;
            values[2] = NumberReaderComboBox.Text;

        }
        public void EditButton_Click(object sender, EventArgs e)
        {
            if(!FormService.IsValidData(CodeNumberTextBox, StatusTextBox, NumberReaderComboBox))
            {
                MessageBox.Show("Усі поля повинні бути заповненими");
                return;
            }
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                FillValuesArr();
                ColumnValuePair[] columnValues = DatabaseHelper.GetColumnValues(columnNames, types, values);
                string result = DatabaseHelper.UpdateRecordSqlQuery("Журнал", new ColumnValuePair("Код_УДК", "string", CodeNumberTextBox.Text), columnValues);
     
                DatabaseHelper.SaveToDataBaseWithoutResult(result, DbConnection);
                FormService.UpdateListViewWithDB(MagazineListView, DbConnection, "SELECT * FROM Журнал", 3);
            }
            else
            {
                MessageBox.Show("Виберіть поле для редагування!");
            }
        }
        public void RemoveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumberReaderComboBox.Text))
            {
                string result = DatabaseHelper.DeleteRecordSqlQuery("Журнал", new ColumnValuePair("Код_УДК", "string", CodeNumberTextBox.Text));
                DatabaseHelper.SaveToDataBaseWithoutResult(result, DbConnection);
                FormService.UpdateListViewWithDB(MagazineListView, DbConnection, "SELECT * FROM Журнал", 3);
            }
            else
            {
                MessageBox.Show("Виберіть поле для видалення!");
            }
        }
        public void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }
    }
}
