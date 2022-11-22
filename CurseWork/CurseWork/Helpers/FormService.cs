using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork
{
    public static class FormService
    {
        public static void UpdateListViewWithDB(ListView listView, OleDbConnection dbConnection, string sqlQuery, int countColumns)
        {
            listView.Items.Clear();
            OleDbCommand command = new OleDbCommand(sqlQuery, dbConnection); ;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader.GetValue(0).ToString();
                for (int j = 1; j <= countColumns - 1; j++)
                {
                    listViewItem.SubItems.Add(reader.GetValue(j).ToString());
                }

                listView.Items.Add(listViewItem);
            }

            reader.Close();
        }

        public static void LoadComboBoxFromDB(ComboBox combobox, OleDbConnection dbConnection, string sqlQuery)
        {
            OleDbCommand command = new OleDbCommand(sqlQuery, dbConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                combobox.Items.Add(reader.GetValue(0));
            }

            reader.Close();
        }

        public static void SelectRowInComboBox(ComboBox comboBox, string textToChoose)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i].ToString() == textToChoose)
                {
                    comboBox.SelectedIndex = i;
                    break;
                }
            }
        }

        public static void RebuildListView(ListView listView, params string[] columns)
        {
            listView.Clear();
            for (int i = 0; i < columns.Length; i++)
            {
                listView.Columns.Add(columns[i]);
            }
        }

        public static bool IsValidData(params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        return false;
                    }
                }

                else if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
