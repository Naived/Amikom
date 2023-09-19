using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Selamat_Datang
{
    public partial class frmSelamatDatang : Form
    {
        public frmSelamatDatang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKeterangan1_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = "Devin Branwen";
            lblKeterangan2.Text = "22.11.4579";
            lblKeterangan3.Text = "IF 01";
        }

        private void btnKeterangan2_Click(object sender, EventArgs e)
        {
            lblKeterangan.Text = " ";
            lblKeterangan2.Text = " ";
            lblKeterangan3.Text = " ";
        }

        private void lblKeterangan_Click(object sender, EventArgs e)
        {

        }
    }
}
