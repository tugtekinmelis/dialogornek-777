using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog_ornek_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                pbResimSec.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = colorDialog1.ShowDialog();

            if(sonuc == DialogResult.OK)
            {
                rtbMesaj.SelectionColor = colorDialog1.Color;
            }
        }
    }
}
