using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class GenresTable : Form, ITableDatabase
    {
        public GenresTable()
        {
            InitializeComponent();
            DbConnection = new OleDbConnection(DataBaseController.DatabaseConnection);
            DbConnection.Open();
        }

        public OleDbConnection DbConnection { get; }

        public void AddButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void RemoveButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void TableForm_Load(object sender, EventArgs e)
        {
        }

        public void TableListViewItem_Selected(object sender, EventArgs e)
        {
        }

        public void Table_Closed(object sender, FormClosedEventArgs e)
        {
            DbConnection.Close();
        }
    }
}
