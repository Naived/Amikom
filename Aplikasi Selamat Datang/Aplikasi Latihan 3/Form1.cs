using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Latihan_3
{
    public partial class frmLatihanTiga3 : Form
    {
        public frmLatihanTiga3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var nama = txtNama.Text;
            var pendidikan = cmbPendidikan.Text;
            var pekerjaan = lstPekerjaan.Text;

            txtPesan1.Text = string.Format($"Halo {nama}");
            txtPesan2.Text = string.Format($"Pendidikan Anda {pendidikan} ya?");
            txtPesan3.Text = string.Format($"Anda seorang {pekerjaan}, hebat !!!");
        }
    }
}
