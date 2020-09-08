using Picture.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public partial class Form1 : Form
    {
        public string filePath = "";
        public Form1()
        {
            InitializeComponent();
            PicturePresent();
            if (Settings.Default.IsPicture != "")
            {
                pbMain.Image = Image.FromFile(Settings.Default.IsPicture);
                btClear.Enabled = true;
            }
        }

        private void PicturePresent()
        {
            if (filePath != "")
                btClear.Enabled = true;
            else
                btClear.Enabled = false;
        }
        private void btChoose_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                filePath = openFileDialog.FileName;
            pbMain.Image = Image.FromFile(filePath);
            btClear.Enabled = true;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            pbMain.Image = null;
            btClear.Enabled = false;
        }

        public string IsPicture
        {
            get
            {
                return Settings.Default.IsPicture;
            }
            set
            {
                Settings.Default.IsPicture = value;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsPicture = filePath;
            Settings.Default.Save();
        }
    }
}
