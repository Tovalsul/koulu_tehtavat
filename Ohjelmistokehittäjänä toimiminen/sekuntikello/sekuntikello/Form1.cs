using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace sekuntikello
{
    public partial class Form1 : Form
    {
        // En saanut tätä toimimaan näin.
        private Stopwatch stopWatch;
        public Form1()
        {
            InitializeComponent();
        }

        private void kaynnistaButton_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void pysaytaButton_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void nollaaButton_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }
        private void ajastinTimer_Tick(object sender, EventArgs e)
        {
            aikaLabel.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}
