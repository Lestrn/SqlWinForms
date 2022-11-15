using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Table tableForm = new Table();
            tableForm.ChoosedTable = this.TabelsComboBox.Text;
            if (string.IsNullOrEmpty(tableForm.ChoosedTable))
            {
                MessageBox.Show("Вы должны выбрать таблицу!", "Error", MessageBoxButtons.OK);
                return;
            }
            tableForm.ShowDialog();
        }
    }
}
