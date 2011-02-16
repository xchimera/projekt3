using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //TODO: Bind GUI sammen med system
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //TODO: Fjern knap
        }

        private void btnVisFraværMedarbejder_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void btnRFravær_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void btnKalender_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void btnKartotek_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void btnRedigerKartotek_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void tabRegistrer_Fravær_Click(object sender, EventArgs e)
        {

        }
    }
}
