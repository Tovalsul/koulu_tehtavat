using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ristiNollaWindowsFormilla
{
    public partial class ristiNollaWindowsFormilla2 : Form
    {
        public ristiNollaWindowsFormilla2()
        {
            InitializeComponent();
        }

        private void ristiNollaWindowsFormilla2_Load(object sender, EventArgs e)
        {
         
        }

        private void pelaaNappi_Click(object sender, EventArgs e)
        {
            Form1.asetaPelaajienNimet(pelaajaYksiNimi.Text, pelaajaKaksiNimi.Text);
            this.Close();
        }
    }
}
