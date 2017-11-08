using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollablePictureBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                spbxImage.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void comboSizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSizeMode.Text.Length > 0)
            {
                this.spbxImage.SizeMode = (PictureBoxSizeMode)Enum.Parse(typeof(PictureBoxSizeMode),comboSizeMode.Text);
            }

        }
    }
}
