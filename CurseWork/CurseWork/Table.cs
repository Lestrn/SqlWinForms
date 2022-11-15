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
    }
}
