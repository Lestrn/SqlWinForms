using System;
using System.IO;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class Table : Form
    {
        public Table(string choosedTable)
        {
            InitializeComponent();
            ChoosedTable = choosedTable;
        }

        public string ChoosedTable { get; }

        public string ImgFileName { get; set; }

        private void TableForm_Load(object sender, System.EventArgs e)
        {
            switch (ChoosedTable)
            {
                case "Библиотека":
                    LibraryGroupBox.Visible = true;
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
    }
}
