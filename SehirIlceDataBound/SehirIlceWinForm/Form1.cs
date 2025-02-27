using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace SehirIlceWinForm
{
    public partial class Form1 : Form
    {
        DataModel dm = new DataModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sehir> sehirler = dm.SehirleriGetir();
            cb_sehir.ValueMember = "ID";
            cb_sehir.DisplayMember = "Isim";
            cb_sehir.DataSource = sehirler;

            cb_ilce.ValueMember = "ID";
            cb_ilce.DisplayMember = "Isim";
        }

        private void cb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sehir s = (Sehir)cb_sehir.SelectedItem;
            cb_ilce.DataSource = dm.IlceleriGetir(s.ID);
        }
    }
}
