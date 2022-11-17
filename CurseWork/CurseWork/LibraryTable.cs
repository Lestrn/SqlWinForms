using System;
using System.Data.OleDb;
using System.IO;
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

        public string ImgFileName { get; set; }

        private void TableForm_Load(object sender, System.EventArgs e)
        {
            OleDbCommand command;
            OleDbDataReader reader;
            LibraryGroupBox.Visible = true;
            command = new OleDbCommand("SELECT * FROM Бібліотека", _dbConnection);
            reader = command.ExecuteReader();
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
        }

        private void UploadPhotoButton_Click(object sender, System.EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open Image";
                ofd.Filter = "image files(*.jpg; *.png)|*.jpg; *.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImgFileName = ofd.FileName;
                }
            }
        }

        private void OpenPhotoButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ImgFileName))
            {
                MessageBox.Show("Выбирите фото", "Error", MessageBoxButtons.OK);
                return;
            }

            Form imgForm = new PhotoView(Convert.ToBase64String(File.ReadAllBytes(ImgFileName)));
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
                AuthorTextBox.Text = listView.SubItems[1].Text;
                DayOutTextBox.Text = listView.SubItems[2].Text;
                GenreTextBox.Text = listView.SubItems[3].Text;
                CodeTextBox.Text = listView.SubItems[5].Text;
                PublishTextBox.Text = listView.SubItems[6].Text;
                CostTextBox.Text = listView.SubItems[7].Text;
                AmountTextBox.Text = listView.SubItems[8].Text;
                DescriptionTextBox.Text = listView.SubItems[10].Text;
                KeyWordsTextBox.Text = listView.SubItems[11].Text;
            }
            catch { }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand($"UPDATE Бібліотека SET Обкладинка=\'{Convert.ToBase64String(File.ReadAllBytes(ImgFileName))}\' WHERE Назва=\'{BookNameTextBox.Text}\'", _dbConnection);
            command.ExecuteNonQuery();
        }
    }
}
