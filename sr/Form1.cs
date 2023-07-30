using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            progressbar.Value = 0;
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressbar.Value = progressbar.Value + 1;
            progressbar.Text = progressbar.Value + "%";
            if (progressbar.Value >= progressbar.Maximum)
            {
                timer1.Stop();
                //this.Hide();
                mainform f = new mainform();
                // f.ShowDialog();
                this.Hide();
                f.Show();
            }

        }
    }
}
