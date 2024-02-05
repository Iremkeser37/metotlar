using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metotlar
{
    internal class Sekil
    {
        public int uzunkenar { get; set; }
        public int kısakenar { get; set; }
        public void KareYaz()
        {
            int sonuc = this.uzunkenar * this.uzunkenar;
            MessageBox.Show($"şeklin karesi:{sonuc}");
        }
            
             public void sekilCiz(Button btn, Color renk)
        {
            btn.Width = this.uzunkenar;
            btn.Height = this.uzunkenar;
            btn.BackColor = renk;
        }

          public void mesajDegistir(Button btn, string mesaj)

        {
                btn .Text = mesaj;
        }



        

        
    }
}
