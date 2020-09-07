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
        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                filePath = openFileDialog.FileName;
            //MessageBox.Show($"{filePath}");
            pbMain.Image = Image.FromFile(filePath);
        }

            private void btClear_Click(object sender, EventArgs e)
        {

        }
    }
}
