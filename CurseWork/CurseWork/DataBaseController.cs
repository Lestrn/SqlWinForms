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
    }
}
