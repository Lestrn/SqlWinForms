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
                MessageBox.Show("Ви повинні вибрати таблицю!", "Error", MessageBoxButtons.OK);
                return;
            }
 
            Form form = default;
            switch (TabelsComboBox.Text)
            {
                case "Бібліотека":
                    form = new LibraryTable();
                    break;
                case "Журнал":
                    form = new MagazineTable();
                    break;
                case "Читачі":
                    form = new ReadersTable();
                    break;
                case "Видавництво":
                    form = new PublishTable();
                    break;
                case "Автор":
                    form = new AuthorTable();
                    break;
                case "Жанри":
                    form = new GenresTable();
                    break;
            }

            form.ShowDialog();
        }

        private void OpenQueryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(QueryComboBox.Text))
            {
                MessageBox.Show("Ви повинні вибрати запит!", "Error", MessageBoxButtons.OK);
                return;
            }

            Query queryForm = new Query(QueryComboBox.Text);
            queryForm.ShowDialog();
        }
    }
}
