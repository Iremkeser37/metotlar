using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlar
{
    public partial class Form1 : Form
    {
        Color renk = Color.Red;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            Sekil sekil1 = new Sekil();
            sekil1.uzunkenar = Convert.ToInt32(txtSayı1.Text);
            sekil1.kısakenar = Convert.ToInt32(txtSayı2.Text);
           // sekil1.KareYaz();
           sekil1.sekilCiz(btnSekil,renk);
           sekil1.mesajDegistir(btnSekil, txtMesaj.Text);

            btnSekil.Width = Convert.ToInt32(txtSayı1.Text);
            btnSekil.Height = Convert.ToInt32(txtSayı2.Text);
            
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }
    }
}
