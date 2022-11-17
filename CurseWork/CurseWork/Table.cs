using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class Table : Form
    {
        private OleDbConnection _dbConnection;

        public Table(string choosedTable)
        {
            InitializeComponent();
            ChoosedTable = choosedTable;
            _dbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            _dbConnection.Open();
        }

        public string ChoosedTable { get; }

        public string ImgFileName { get; set; }

        private void TableForm_Load(object sender, System.EventArgs e)
        {
            OleDbCommand command;
            OleDbDataReader reader;
            switch (ChoosedTable)
            {
                case "Библиотека":
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

                    break;
                case "Читатели":
                    ReaderGroupBox.Visible = true;
                    break;
                case "Журнал":
                    MagazineGroupBox.Visible = true;
                    break;
            }
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
    }
}
