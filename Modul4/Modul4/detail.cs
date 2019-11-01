using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul4
{
    public partial class detail : Form
    {
        private string no_Plat;
        private string jenis;
        private string merk;
        private string harga;
        private string tahun_buat;
        private string lain_lain;

        public detail()
        {
            //Debug.WriteLine("detail form");
            InitializeComponent();
        }

        public detail(string no_Plat, string jenis, string merk, string harga, string tahun_buat, string lain_lain)
        {
            InitializeComponent();
            this.no_Plat = no_Plat;
            this.jenis = jenis;
            this.merk = merk;
            this.harga = harga;
            this.tahun_buat = tahun_buat;
            this.lain_lain = lain_lain;
        }

       

        private void detail_Load(object sender, EventArgs e)
        {
            this.plat_txt.Text = no_Plat;
            this.jenis_txt.Text = jenis;
            this.merk_txt.Text = merk;
            this.harga_txt.Text = harga;
            this.thnbuat_txt.Text = tahun_buat;
            this.lain_txt.Text = lain_lain;

        }

        private void tutup_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("detail form");
            this.Close();
        }

        private void plat_txt_Click(object sender, EventArgs e)
        {

        }
    }
}