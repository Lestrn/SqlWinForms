
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //void Printer()
        //{
        //    PrintDocument PrintDocument = new PrintDocument();
        //    PrintDocument.PrintPage += (object sender, PrintPageEventArgs e) =>
        //    {
        //        Font font = new Font("Arial", 12);
        //        float offset = e.MarginBounds.Top;
        //        foreach (ListViewItem Item in LibraryListView.Items)
        //        {
        //            for (int i = 0; i < Item.SubItems.Count - 1; i++)
        //            {
        //                offset += (font.GetHeight() + 5.0f);
        //                PointF location = new System.Drawing.PointF(e.MarginBounds.Left, offset);
        //                e.Graphics.DrawString(Item.SubItems[i].Text, font, Brushes.Black, location);
        //            }
        //            // The 5.0f is to add a small space between lines

        //        }
        //    };
        //    PrintDocument.Print();
        //    //foreach (ListViewItem itemRow in LibraryListView.Items)
        //    //{
        //    //    int i = 0;
        //    //    for (i = 0; i < itemRow.SubItems.Count - 1; i++)
        //    //    {
        //    //        pdfTable.AddCell(itemRow.SubItems[i].Text);
        //    //    }
        //    //}

        //}
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
                    MessageBox.Show("VSE AHUENNO");
                }
            }
        }
    }
  
}

