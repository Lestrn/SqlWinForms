using System;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class DataBaseController : Form
    {
        public DataBaseController()
        {
            InitializeComponent();
        }

        private void OpenTableButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TabelsComboBox.Text))
            {
                MessageBox.Show("Вы должны выбрать таблицу!", "Error", MessageBoxButtons.OK);
                return;
            }

            Table tableForm = new Table(TabelsComboBox.Text);
            tableForm.ShowDialog();
        }

        private void OpenQueryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(QueryComboBox.Text))
            {
                MessageBox.Show("Вы должны выбрать запрос!", "Error", MessageBoxButtons.OK);
                return;
            }
            Query queryForm = new Query(QueryComboBox.Text);
            queryForm.ShowDialog();
        }
    }
}
