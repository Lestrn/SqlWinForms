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

        public static string DatabaseConnection { get; } = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../../Database.accdb";

        private void OpenTableButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TabelsComboBox.Text))
            {
                MessageBox.Show("Вы должны выбрать таблицу!", "Error", MessageBoxButtons.OK);
                return;
            }

            Form form = default;
            switch (TabelsComboBox.Text)
            {
                case "Библиотека":
                    form = new LibraryTable();
                    break;
            }

            form.ShowDialog();
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
