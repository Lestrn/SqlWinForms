using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class PhotoView : Form
    {
        public PhotoView(string fileName)
        {
            InitializeComponent();
            FileName = fileName;
        }
        public string FileName { get;}

        private void PhotoView_Load(object sender, EventArgs e)
        {          
            SelectedPicture.Image = Image.FromFile(FileName);
        }
    }
}
