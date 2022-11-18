using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork
{
    public interface ITableDatabase
    {
        OleDbConnection DbConnection { get; }

        void TableForm_Load(object sender, System.EventArgs e);

        void Table_Closed(object sender, FormClosedEventArgs e);

        void TableListViewItem_Selected(object sender, EventArgs e);

        void EditButton_Click(object sender, EventArgs e);

        void RemoveButton_Click(object sender, EventArgs e);

        void AddButton_Click(object sender, EventArgs e);
    }
}
