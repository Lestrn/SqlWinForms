using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurseWork
{
    public partial class PhotoView : Form
    {
        public PhotoView(string base64Img)
        {
            InitializeComponent();
            Base64Img = base64Img;
        }

        public string Base64Img { get;}

        private void PhotoView_Load(object sender, EventArgs e)
        {
            using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(Base64Img)))
            {
                SelectedPicture.Image = Image.FromStream(memoryStream);
            }
        }
    }
}