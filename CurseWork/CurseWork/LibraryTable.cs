using System;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class LibraryTable : Form
    {
        private OleDbConnection _dbConnection;

        public LibraryTable()
        {
            InitializeComponent();
            _dbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            _dbConnection.Open();
        }

        public string Img64BaseString { get; set; }

        private void TableForm_Load(object sender, System.EventArgs e)
        {
            OleDbCommand command = new OleDbCommand("SELECT * FROM Бібліотека", _dbConnection); ;
            OleDbDataReader reader = command.ExecuteReader();
            LibraryGroupBox.Visible = true;
            LibraryListView.FullRowSelect = true;
            while (reader.Read())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = reader.GetString(0);
                for (int j = 1; j <= 11; j++)
                {
                    listViewItem.SubItems.Add(reader.GetValue(j).ToString());
                }

                LibraryListView.Items.Add(listViewItem);
            }
            reader.Close();
            command = new OleDbCommand("SELECT Код_автора FROM Автори", _dbConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                AuthorComboBox.Items.Add(reader.GetValue(0));
            }

            reader.Close();

            command = new OleDbCommand("SELECT Код_УДК FROM Журнал", _dbConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                CodeUDKComboBox.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            command = new OleDbCommand("SELECT Код FROM Видавництво", _dbConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                PublishComboBox.Items.Add(reader.GetValue(0));
            }
            reader.Close();

            command = new OleDbCommand("SELECT Код_жанра FROM Жанри", _dbConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                GenresComboBox.Items.Add(reader.GetValue(0));
            }
            reader.Close();
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
        
        private void Table_Closed(object sender, FormClosedEventArgs e)
        {
            _dbConnection.Close();
        }

        private void LibraryListViewItem_Selected(object sender, EventArgs e)
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
                for (int i = 0; i < AuthorComboBox.Items.Count; i++)
                {
                    if (AuthorComboBox.Items[i].ToString() == listView.SubItems[1].Text)
                    {
                        AuthorComboBox.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < CodeUDKComboBox.Items.Count; i++)
                {
                    if (CodeUDKComboBox.Items[i].ToString() == listView.SubItems[5].Text)
                    {
                        CodeUDKComboBox.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < PublishComboBox.Items.Count; i++)
                {
                    if (PublishComboBox.Items[i].ToString() == listView.SubItems[6].Text)
                    {
                        PublishComboBox.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < GenresComboBox.Items.Count; i++)
                {
                    if (GenresComboBox.Items[i].ToString() == listView.SubItems[3].Text)
                    {
                        GenresComboBox.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < NewDayOutComboBox.Items.Count; i++)
                {
                    if (NewDayOutComboBox.Items[i].ToString() == listView.SubItems[9].Text)
                    {
                        NewDayOutComboBox.SelectedIndex = i;
                        break;
                    }
                }
            }
            catch { }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (LibraryListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите строку для редактирования", "Error", MessageBoxButtons.OK);
                return;
            }
            //Назва_книги ={ BookNameTextBox.Text}, Код_автора_книги ={ int.Parse(AuthorComboBox.Text)}, Рік_видання ={ int.Parse(DayOutTextBox.Text)}, Код_жанру ={ int.Parse(GenresComboBox.Text)}, Обкладинка ={ Img64BaseString}, Код_УДК ={ CodeUDKComboBox.Text}, Код_видавництва ={ int.Parse(PublishComboBox.Text)}, Ціна ={ decimal.Parse(CostTextBox.Text)}, Кількість_у_бібліотеці ={ int.Parse(AmountTextBox.Text)}, Чи_є_новим_виданням ={ NewDayOutComboBox.Text}, Ключові_слова ={ KeyWordsTextBox.Text}
            //WHERE Назва = { BookNameTextBox.Text } Примітки_коротка_анотація ={ DescriptionTextBox.Text}
            //$"UPDATE Бібліотека SET Назва_книги=\'{ BookNameTextBox.Text}\', Код_автора_книги={ int.Parse(AuthorComboBox.Text)}, Рік_видання={ int.Parse(DayOutTextBox.Text)}, Код_жанру={ int.Parse(GenresComboBox.Text)}, Обкладинка=\'{Img64BaseString}\', Код_УДК=\'{ CodeUDKComboBox.Text}\', Код_видавництва={ int.Parse(PublishComboBox.Text)}, Ціна={ decimal.Parse(CostTextBox.Text)}, Кількість_у_бібліотеці={ int.Parse(AmountTextBox.Text)}, Чи_є_новим_виданням=\'{ NewDayOutComboBox.Text}\', Ключові_слова={ KeyWordsTextBox.Text}, Примітки_коротка_анотація={ DescriptionTextBox.Text} WHERE Назва_книги=\'{BookNameTextBox.Text}\'"
            OleDbCommand command = new OleDbCommand("UPDATE Бібліотека SET Назва_книги=\'" + BookNameTextBox.Text + "\', " +
                "Код_автора_книги=" + int.Parse(AuthorComboBox.Text) + ", " +
                "Рік_видання=" + int.Parse(DayOutTextBox.Text) + ", " +
                "Примітки_коротка_анотація=\'" + DescriptionTextBox.Text + "\' " +
                "Ключові_слова=\'" + KeyWordsTextBox.Text + "\' " +
                "WHERE Назва_книги=\'" + BookNameTextBox.Text + "\'", _dbConnection);
            command.ExecuteNonQuery();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (LibraryListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления", "Error", MessageBoxButtons.OK);
                return;
            }

            OleDbCommand command = new OleDbCommand($"DELETE FROM Бібліотека WHERE Назва_книги=\'{BookNameTextBox.Text}\'", _dbConnection);
            command.ExecuteNonQuery();
        }
    }
}
