using System;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class LibraryTable : Form, ITableDatabase
    {
        public LibraryTable()
        {
            InitializeComponent();
            DbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            DbConnection.Open();
        }

        public string Img64BaseString { get; set; }

        public OleDbConnection DbConnection { get; }

        public void TableForm_Load(object sender, System.EventArgs e)
        {
            LibraryGroupBox.Visible = true;
            LibraryListView.FullRowSelect = true;
            FormService.UpdateListViewWithDB(LibraryListView, DbConnection, "SELECT * FROM Бібліотека", 12);
            FormService.LoadComboBoxFromDB(AuthorComboBox, DbConnection, "SELECT Код_автора FROM Автори");
            FormService.LoadComboBoxFromDB(CodeUDKComboBox, DbConnection, "SELECT Код_УДК FROM Журнал");
            FormService.LoadComboBoxFromDB(PublishComboBox, DbConnection, "SELECT Код FROM Видавництво");
            FormService.LoadComboBoxFromDB(GenresComboBox, DbConnection, "SELECT Код_жанра FROM Жанри");
        }

        private void UploadPhotoButton_Click(object sender, System.EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open Image";
                ofd.Filter = "image files(*.jpg; *.png)|*.jpg; *.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Img64BaseString = Convert.ToBase64String(File.ReadAllBytes(ofd.FileName));
                }
            }
        }

        private void OpenPhotoButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Img64BaseString))
            {
                MessageBox.Show("Выбирите фото", "Error", MessageBoxButtons.OK);
                return;
            }

            Form imgForm = new PhotoView(Img64BaseString);
            imgForm.ShowDialog();
        }
        
        public void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }

        public void TableListViewItem_Selected(object sender, EventArgs e)
        {
            try
            {
                var listView = LibraryListView.SelectedItems[0];
                BookNameTextBox.Text = listView.SubItems[0].Text;
                DayOutTextBox.Text = listView.SubItems[2].Text;
                CostTextBox.Text = listView.SubItems[7].Text;
                AmountTextBox.Text = listView.SubItems[8].Text;
                DescriptionTextBox.Text = listView.SubItems[10].Text;
                KeyWordsTextBox.Text = listView.SubItems[11].Text;
                Img64BaseString = listView.SubItems[4].Text;
                FormService.SelectRowInComboBox(AuthorComboBox, listView.SubItems[1].Text);
                FormService.SelectRowInComboBox(CodeUDKComboBox, listView.SubItems[5].Text);
                FormService.SelectRowInComboBox(PublishComboBox, listView.SubItems[6].Text);
                FormService.SelectRowInComboBox(GenresComboBox, listView.SubItems[3].Text);
                FormService.SelectRowInComboBox(NewDayOutComboBox, listView.SubItems[9].Text);
            }
            catch { }
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            if (LibraryListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите строку для редактирования", "Error", MessageBoxButtons.OK);
                return;
            }

            var updateQuery = DatabaseHelper.UpdateRecordSqlQuery("Бібліотека", new ColumnValue("Назва_книги", "string", BookNameTextBox.Text), new ColumnValue[]
            {
                new ColumnValue("Назва_книги", "string", BookNameTextBox.Text),
                new ColumnValue("Код_автора_книги", "int", AuthorComboBox.Text),
                new ColumnValue("Рік_видання", "int", DayOutTextBox.Text),
                new ColumnValue("Код_жанру", "int", GenresComboBox.Text),
                new ColumnValue("Обкладинка", "string", Img64BaseString),
                new ColumnValue("Код_УДК", "string", CodeUDKComboBox.Text),
                new ColumnValue("Код_видавництва", "int", PublishComboBox.Text),
                new ColumnValue("Ціна", "decimal", CostTextBox.Text),
                new ColumnValue("Кількість_у_бібліотеці", "int", AmountTextBox.Text),
                new ColumnValue("Чи_є_новим_виданням", "string", NewDayOutComboBox.Text),
                new ColumnValue("Примітки_коротка_анотація", "string", DescriptionTextBox.Text),
                new ColumnValue("Ключові_слова", "string", KeyWordsTextBox.Text)
            });
            OleDbCommand command = new OleDbCommand(updateQuery, DbConnection);
            command.ExecuteNonQuery();
            FormService.UpdateListViewWithDB(LibraryListView, DbConnection, "SELECT * FROM Бібліотека", 12);
        }

        public void RemoveButton_Click(object sender, EventArgs e)
        {
            if (LibraryListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления", "Error", MessageBoxButtons.OK);
                return;
            }

            var deleteQuery = DatabaseHelper.DeleteRecordSqlQuery("Бібліотека", new ColumnValue("Назва_книги", "string", BookNameTextBox.Text));
            MessageBox.Show(deleteQuery, "Error", MessageBoxButtons.OK);
            OleDbCommand command = new OleDbCommand(deleteQuery, DbConnection);
            command.ExecuteNonQuery();
            FormService.UpdateListViewWithDB(LibraryListView, DbConnection, "SELECT * FROM Бібліотека", 12);
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            var createQuery = DatabaseHelper.CreateRecordSqlQuerry("Бібліотека", new ColumnValue[]
            {
                new ColumnValue("Назва_книги", "string", BookNameTextBox.Text),
                new ColumnValue("Код_автора_книги", "int", AuthorComboBox.Text),
                new ColumnValue("Рік_видання", "int", DayOutTextBox.Text),
                new ColumnValue("Код_жанру", "int", GenresComboBox.Text),
                new ColumnValue("Обкладинка", "string", Img64BaseString),
                new ColumnValue("Код_УДК", "string", CodeUDKComboBox.Text),
                new ColumnValue("Код_видавництва", "int", PublishComboBox.Text),
                new ColumnValue("Ціна", "decimal", CostTextBox.Text),
                new ColumnValue("Кількість_у_бібліотеці", "int", AmountTextBox.Text),
                new ColumnValue("Чи_є_новим_виданням", "string", NewDayOutComboBox.Text),
                new ColumnValue("Примітки_коротка_анотація", "string", DescriptionTextBox.Text),
                new ColumnValue("Ключові_слова", "string", KeyWordsTextBox.Text)
            });
            OleDbCommand command = new OleDbCommand(createQuery, DbConnection);
            command.ExecuteNonQuery();
            FormService.UpdateListViewWithDB(LibraryListView, DbConnection, "SELECT * FROM Бібліотека", 12);
        }
    }
}
