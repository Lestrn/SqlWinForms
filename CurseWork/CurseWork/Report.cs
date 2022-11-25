using Microsoft.Office.Interop.Excel;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class Report : Form
    {

        public Report()
        {
            InitializeComponent();
            DbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            DbConnection.Open();
        }

        public OleDbConnection DbConnection { get; }

        private void Report_Load(object sender, EventArgs e)
        {
            LibraryListView.FullRowSelect = true;
            FormService.UpdateListViewWithDB(LibraryListView, DbConnection, "SELECT * FROM Бібліотека", 12);
        }

        private void Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            ToExcel();
        }
        public void ToExcel()
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true})
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                    Workbook workbook = application.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet worksheet = (Worksheet)application.ActiveSheet;
                    application.Visible = false;
                    worksheet.Cells[1, 1] = "Назва книги";
                    worksheet.Cells[1, 2] = "Код автора";
                    worksheet.Cells[1, 3] = "Рік видання";
                    worksheet.Cells[1, 4] = "Код жанру";
                    worksheet.Cells[1, 5] = "Обкладенка";
                    worksheet.Cells[1, 6] = "Код УДК";
                    worksheet.Cells[1, 7] = "Код Видавництва";
                    worksheet.Cells[1, 8] = "Ціна";
                    worksheet.Cells[1, 9] = "Кількість у бібліотеці";
                    worksheet.Cells[1, 10] = "Че є новим виданням";
                    worksheet.Cells[1, 11] = "Примітки";
                    worksheet.Cells[1, 12] = "Ключові слова";
                    int i = 2;
                    foreach (ListViewItem item in LibraryListView.Items)
                    {
                        for (int j = 1, h = 0; j <= 12; j++, h++)
                        {
                            worksheet.Cells[i, j] = item.SubItems[h].Text;
                        }
                        i++;
                    }
                    workbook.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    application.Quit();
                    MessageBox.Show("Saved!");
                }
            }
        }
    }
  
}

