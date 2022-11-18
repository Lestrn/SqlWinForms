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
                listViewItem.Text = reader.GetString(0);
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
    }
}
